namespace TravelBlog.API.Models.DTOs;
public class PostDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
    public string? Location { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }

    public Guid CategoryId { get; set; }
    public string? CategoryName { get; set; }
}