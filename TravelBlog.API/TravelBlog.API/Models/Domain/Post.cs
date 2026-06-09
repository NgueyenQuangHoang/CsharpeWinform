using TravelBlog.API.Models.Domain;

namespace TravelBlog.API.Models.Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public required string Title { get; set; } 
        public string? Content { get; set; }
        public string? Location { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign key
        public Guid CategoryId { get; set; }

        // Navigation property - một post chỉ thuộc về một category
        public Category Category { get; set; } = null!;
    }
}
