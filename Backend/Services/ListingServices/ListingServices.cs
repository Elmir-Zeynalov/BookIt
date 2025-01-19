using Backend.Database;
using Backend.Dtos;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services.ListingServices
{
    public class ListingServices : IListingServices
    {

        private readonly AppDbContext _dbContext;
        public ListingServices(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Listing> CreateListingAsync(ListingCreateDto listingDto)
        {
            var listing = new Listing
            {
                Title = listingDto.Title,
                Description = listingDto.Description,
                Location = listingDto.Location,
                Rooms = listingDto.Rooms,
                Price = listingDto.Price,
                UserID = listingDto.UserId
            };

            _dbContext.Listings.Add(listing);
            await _dbContext.SaveChangesAsync();
            return listing;
        }
        public async Task<List<Listing>> GetAllListingsAsync()
        {
            return await _dbContext.Listings.ToListAsync();
        }

        public async Task<Listing?> GetListingByIdAsync(int id)
        {
            return await _dbContext.Listings.FindAsync(id);
        }
    }
}
