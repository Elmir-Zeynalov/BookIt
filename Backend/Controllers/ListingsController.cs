using Backend.Dtos;
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
        public ListingsController(ILogger<ListingsController> logger, IListingServices listingServices)
        {
            _logger = logger;
            _listingServices = listingServices;
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var listing = await _listingServices.CreateListingAsync(listingDto);

            return CreatedAtAction(nameof(GetListing), new { id = listing.ListingID }, listing);
        }
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
                listing.Rooms,
                listing.Price,
                listing.Availability,
                listing.CreatedDate,
                listing.UserID
            });
        }
    }
}
