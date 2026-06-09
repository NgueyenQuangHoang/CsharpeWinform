namespace TravelBlog.API.Models.DTOs
{
    public class CreatePostDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public string? Location { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
    }
}