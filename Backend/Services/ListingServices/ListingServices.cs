using Backend.Dtos;
using Backend.Models;

namespace Backend.Services.ListingServices
{
    public class ListingServices : IListingServices
    {
        public Task<Listing> CreateListingAsync(ListingCreateDto listingDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<Listing>> GetAllListingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Listing> GetListingByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
