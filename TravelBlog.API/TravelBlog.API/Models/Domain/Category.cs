using TravelBlog.API.Models.Domain;

namespace TravelBlog.API.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        //Navigation property - một category có thể có nhiều post
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
