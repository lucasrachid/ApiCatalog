using ApiCatalog.Application.DTOs;

namespace ApiCatalog.Application.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
    Task<CategoryDto> GetCategoryByIdAsync(Guid id);
    Task<Guid> CreateCategoryAsync(CategoryDto categoryDto);
    Task UpdateCategoryAsync(Guid id, CategoryDto categoryDto);
    Task DeleteCategoryAsync(Guid id);
}