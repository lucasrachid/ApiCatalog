using ApiCatalog.Application.DTOs;

namespace ApiCatalog.Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProductsAsync();
    Task<ProductDto?> GetProductByIdAsync(Guid id);
    Task<Guid> CreateProductAsync(ProductDto productDto);
    Task UpdateProductAsync(Guid id, ProductDto productDto);
    Task DeleteProductAsync(Guid id);
}