using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ListingImage
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        [MaxLength(500)] 
        public string ImageURL { get; set; } = string.Empty;

        // Foreign Key
        [Required]
        public int ListingID { get; set; }

        public Listing Listing { get; set; } = null!;
    }
}
