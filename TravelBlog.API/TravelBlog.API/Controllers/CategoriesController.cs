using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBlog.API.Data;
using TravelBlog.API.Models.Domain;
using TravelBlog.API.Models.DTOs;

namespace TravelBlog.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly TravelDbContext dbContext;

    public CategoriesController(TravelDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await dbContext.Categories.ToListAsync();
        return Ok(categories);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var category = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);

        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCategoryDto request)
    {
        var category = new Category
        {
            Id = Guid.NewGuid(),
            Name = request.Name
        };

        await dbContext.Categories.AddAsync(category);
        await dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var category = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);

        if (category == null)
        {
            return NotFound();
        }

        dbContext.Categories.Remove(category);
        await dbContext.SaveChangesAsync();

        return Ok(category);
    }
}
