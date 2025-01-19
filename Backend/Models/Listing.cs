using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Listing
    {
        [Key] // Primary Key
        public int ListingID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Location { get; set; } = string.Empty;

        [Required]
        [Range(1, 100)] // Example range for number of rooms
        public int Rooms { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")] // Explicit precision for decimal in SQL
        public decimal Price { get; set; }

        public string? Availability { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        // Foreign Key
        [Required]
        public Guid UserID { get; set; }

        // Navigation Properties
        public User User { get; set; } = null!;
        public ICollection<ListingImage> Images { get; set; } = new List<ListingImage>();
    }
}
