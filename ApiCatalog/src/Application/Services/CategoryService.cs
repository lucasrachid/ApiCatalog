using ApiCatalog.Application.DTOs;
using ApiCatalog.Application.Interfaces;
using ApiCatalog.Domain.Models;
using AutoMapper;

namespace ApiCatalog.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
    {
        var categories = await _categoryRepository.GetAllCategoriesAsync();
        return _mapper.Map<IEnumerable<CategoryDto>>(categories);
    }

    public async Task<CategoryDto> GetCategoryByIdAsync(Guid id)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(id);
        return _mapper.Map<CategoryDto>(category);
    }

    public async Task<Guid> CreateCategoryAsync(CategoryDto categoryDto)
    {
        var category = _mapper.Map<Category>(categoryDto);
        await _categoryRepository.AddCategoryAsync(category);
        return category.Id;
    }

    public async Task UpdateCategoryAsync(Guid id, CategoryDto categoryDto)
    {
        var category = _mapper.Map<Category>(categoryDto);
        category.Id = id;
        await _categoryRepository.UpdateCategoryAsync(category);
    }

    public async Task DeleteCategoryAsync(Guid id)
    {
        await _categoryRepository.DeleteCategoryAsync(id);
    }
}