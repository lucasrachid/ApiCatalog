using ApiCatalog.Application.DTOs;
using ApiCatalog.Application.Interfaces;
using ApiCatalog.Domain.Models;
using AutoMapper;

namespace ApiCatalog.Application.Services;

public class ProductService : IProductService 
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper; 

    public ProductService(IProductRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ProductDto>> GetProductsAsync()
    {
        var products = await _repository.GetProductsAsync();
        return _mapper.Map<IEnumerable<ProductDto>>(products);
    }

    public async Task<ProductDto?> GetProductByIdAsync(Guid id)
    {
        var product = await _repository.GetProductByIdAsync(id);
        return product == null ? null : _mapper.Map<ProductDto>(product);
    }

    // Usando AutoMapper para mapear de ProductDto para Product
    public async Task<Guid> CreateProductAsync(ProductDto productDto)
    {
        var product = _mapper.Map<Product>(productDto);
        await _repository.AddProductAsync(product);
        return product.Id;
    }

    public async Task UpdateProductAsync(Guid id, ProductDto productDto)
    {
        var product = _mapper.Map<Product>(productDto);
        product.Id = id;
        await _repository.UpdateProductAsync(product);
    }

    public async Task DeleteProductAsync(Guid id)
    {
        var product = await _repository.GetProductByIdAsync(id);
        if (product != null)
        {
            await _repository.DeleteProductAsync(product);
        }
    }
}