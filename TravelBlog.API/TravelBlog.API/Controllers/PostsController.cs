using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TravelBlog.API.Models.DTOs;
using TravelBlog.API.Data;
using TravelBlog.API.Models.Domain;
using Microsoft.AspNetCore.Authorization;

namespace TravelBlog.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly TravelDbContext dbContext;

    public PostsController(TravelDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery,
        [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        // Bảo vệ input để tránh lỗi linh tinh
        if (pageNumber < 1)
        {
            pageNumber = 1;
        }

        if (pageSize < 1)
        {
            pageSize = 10;
        }

        // Giới hạn pageSize để tránh client lấy quá nhiều
        if (pageSize > 100)
        {
            pageSize = 100;
        }

        var postsQuery = dbContext.Posts.AsQueryable();

        // Filtering
        if (!string.IsNullOrWhiteSpace(filterOn) &&
            !string.IsNullOrWhiteSpace(filterQuery))
        {
            if (filterOn.Equals("Location", StringComparison.OrdinalIgnoreCase))
            {
                postsQuery = postsQuery.Where(x =>
                    x.Location != null &&
                    x.Location.Contains(filterQuery));
            }

            if (filterOn.Equals("Title", StringComparison.OrdinalIgnoreCase))
            {
                postsQuery = postsQuery.Where(x =>
                    x.Title.Contains(filterQuery));
            }
        }
        // Nên order trước khi pagination để kết quả ổn định
        postsQuery = postsQuery.OrderByDescending(x => x.CreatedAt);

        // Tổng số bản ghi sau khi filter
        var totalRecords = await postsQuery.CountAsync();

        // Tính số bản ghi cần bỏ qua
        var skipResults = (pageNumber - 1) * pageSize;

        // Lấy dữ liệu theo trang
        var posts = await postsQuery
            .Skip(skipResults)
            .Take(pageSize)
            .ToListAsync();

        // Trả về cả metadata để frontend dễ dùng
        var response = new
        {
            pageNumber,
            pageSize,
            totalRecords,
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize),
            data = posts
        };
        return Ok(response);
    }
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var post = await dbContext.Posts
            .Include(x => x.Category)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (post == null)
        {
            return NotFound();
        }
        var postDto = new PostDto
        {
            Id = post.Id,
            Title = post.Title,
            Content = post.Content,
            Location = post.Location,
            ImageUrl = post.ImageUrl,
            CreatedAt = post.CreatedAt,
            CategoryId = post.CategoryId,
            CategoryName = post.Category.Name
        };
        return Ok(post);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] CreatePostDto request)
    {
        var post = new Post
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Content = request.Content,
            Location = request.Location,
            ImageUrl = request.ImageUrl,
            CategoryId = request.CategoryId,
            CreatedAt = DateTime.UtcNow
        };

        await dbContext.Posts.AddAsync(post);
        await dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAll), new { id = post.Id }, post);
    }
}