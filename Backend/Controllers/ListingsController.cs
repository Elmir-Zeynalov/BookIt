using Backend.Dtos;
using Backend.Services.BlobStorageServices;
using Backend.Services.ListingServices;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("/Listings")]
    public class ListingsController : Controller
    {
        private readonly ILogger<ListingsController> _logger;
        private readonly IListingServices _listingServices;
        private readonly IBlobImageHandlingServices _imageHandlingServices;

        public ListingsController(ILogger<ListingsController> logger, IListingServices listingServices, IBlobImageHandlingServices imageHandlingServices)
        {
            _logger = logger;
            _listingServices = listingServices;
            _imageHandlingServices = imageHandlingServices;
        }

        /// <summary>
        /// Get all listings
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAllListings")]
        public async Task<IActionResult> Get()
        {
            var listings = await _listingServices.GetAllListingsAsync();
            return Ok(listings);
        }

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="listingDto">The listing data transfer object.</param>
        /// <returns>The created listing.</returns>
        [HttpPost("CreateListing", Name = "PostListing")]
        public async Task<IActionResult> Post(ListingCreateDto listingDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var listing = await _listingServices.CreateListingAsync(listingDto);
                if (listing == null)
                {
                    return BadRequest(new { message = "Error creating Listing" });
                }

                var images = await _imageHandlingServices.UploadImagesAsync(listingDto.Images);
                if (images == null)
                {
                    return BadRequest(new { message = "Error uploading images" });
                }

                return CreatedAtAction(nameof(GetListing), new { id = listing.ListingID }, listing);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while creating the listing.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "An unexpected error occurred. Please try again later." });
            }
        }

        /// <summary>
        /// Get a listing by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A listing with the specified id</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetListing(int id)
        {
            var listing = await _listingServices.GetListingByIdAsync(id);
            if (listing == null) return NotFound();
            return Ok(new
            {
                listing.ListingID,
                listing.Title,
                listing.Description,
                listing.Location,
                listing.NumberOfRooms,
                listing.Price,
                listing.Availability,
                listing.CreatedDate,
                listing.UserID
            });
        }
    }
}
