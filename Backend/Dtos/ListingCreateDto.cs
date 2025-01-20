using System.ComponentModel.DataAnnotations;

namespace Backend.Dtos
{
    public class ListingCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int NumberOfRooms { get; set; }
        public decimal Price { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public List<IFormFile>? Images { get; set; }
    }
}
