using ApiCatalog.Application.Interfaces;
using ApiCatalog.Infrastructure.Data.Context;
using ApiCatalog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalog.Infrastructure.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await (_context.Product?.ToListAsync() ?? Task.FromResult(new List<Product>()));
    }

    public async Task<Product?> GetProductByIdAsync(Guid id)
    {
        return await _context.Product!.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task AddProductAsync(Product product)
    {
        _context.Product!.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(Product product)
    {
        _context.Product!.Remove(product);
        await _context.SaveChangesAsync();
    }
}