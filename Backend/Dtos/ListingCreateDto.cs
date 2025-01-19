namespace Backend.Dtos
{
    public class ListingCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Rooms { get; set; }
        public decimal Price { get; set; }
        public Guid UserId { get; set; }
    }
}
