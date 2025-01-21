using Backend.Database;
using Backend.Models;

namespace Backend.Services.BlobStorageServices
{
    public class BlobImageHandlingServices : IBlobImageHandlingServices
    {
        private readonly IBlobStorageService _blobStorageService;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<BlobImageHandlingServices> _logger;

        public BlobImageHandlingServices(IBlobStorageService blobStorageService, AppDbContext dbContext, ILogger<BlobImageHandlingServices> logger)
        {
            _blobStorageService = blobStorageService;
            _dbContext = dbContext;
            _logger = logger;
        }
        public async Task<List<ListingImage>> UploadImagesAsync(List<IFormFile>? images, int listingId)
        {
            try
            {
                if (images == null)
                {
                    return new List<ListingImage>();
                }

                List<ListingImage> uploadedImages = new();

                foreach (var image in images)
                {
                    var uploadedImage = await _blobStorageService.UploadImageAsync(image);

                    var ListingImage = new ListingImage
                    {
                        ListingID = listingId,
                        ImageURL = uploadedImage
                    };
                    uploadedImages.Add(ListingImage);
                }

                await _dbContext.ListingImages.AddRangeAsync(uploadedImages);
                await _dbContext.SaveChangesAsync();

                return uploadedImages;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while uploading images.");
                throw; // Re-throw the exception to propagate it to the caller

            }
        }
    }
}
