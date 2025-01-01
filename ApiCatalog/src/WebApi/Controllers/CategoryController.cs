using ApiCatalog.Application.DTOs;
using ApiCatalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalog.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
    {
        var categories = await _categoryService.GetCategoriesAsync();
        return Ok(categories);
    }

    [HttpGet("{id}", Name = "GetCategory")]
    public async Task<ActionResult<CategoryDto>> GetCategory(Guid id)
    {
        var category = await _categoryService.GetCategoryByIdAsync(id);
        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateCategory(CategoryDto categoryDto)
    {
        var categoryId = await _categoryService.CreateCategoryAsync(categoryDto);
        return CreatedAtRoute("GetCategory", new { id = categoryId }, categoryId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateCategory(Guid id, CategoryDto categoryDto)
    {
        await _categoryService.UpdateCategoryAsync(id, categoryDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCategory(Guid id)
    {
        await _categoryService.DeleteCategoryAsync(id);
        return NoContent();
    }
}