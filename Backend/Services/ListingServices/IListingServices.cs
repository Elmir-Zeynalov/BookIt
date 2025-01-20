using Backend.Dtos;
using Backend.Models;

namespace Backend.Services.ListingServices
{
    public interface IListingServices
    {

        public Task<List<Listing>> GetAllListingsAsync();
        public Task<Listing> CreateListingAsync(ListingCreateDto listingDto);
        public Task<Listing?> GetListingByIdAsync(int id);
    }
}
