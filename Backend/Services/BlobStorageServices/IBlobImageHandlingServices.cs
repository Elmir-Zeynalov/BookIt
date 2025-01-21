using Backend.Models;

namespace Backend.Services.BlobStorageServices
{
    public interface IBlobImageHandlingServices
    {
        Task<List<ListingImage>> UploadImagesAsync(List<IFormFile>? images, int listingId);

    }
}
