using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class User
    {
        [Key]
        public required Guid Id { get; init; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        [EmailAddress]
        [MaxLength(255)]
        public required string Email { get; set; }

        [MinLength(6)]
        public required string Password { get; set; }


        public ICollection<Listing> Listings { get; set; } = new List<Listing>();
    }
}
