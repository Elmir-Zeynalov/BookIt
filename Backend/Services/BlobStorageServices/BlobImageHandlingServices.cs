using Backend.Database;
using Backend.Models;

namespace Backend.Services.BlobStorageServices
{
    public class BlobImageHandlingServices : IBlobImageHandlingServices
    {
        private readonly IBlobStorageService _blobStorageService;
        private readonly AppDbContext _dbContext;

        public BlobImageHandlingServices(IBlobStorageService blobStorageService, AppDbContext dbContext)
        {
            _blobStorageService = blobStorageService;
            _dbContext = dbContext;
        }
        public async Task<List<ListingImage>> UploadImagesAsync(List<IFormFile>? images, int listingId)
        {
            if(images == null)
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
    }
}
