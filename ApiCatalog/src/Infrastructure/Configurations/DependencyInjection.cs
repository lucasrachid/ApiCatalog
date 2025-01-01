using ApiCatalog.Application.Interfaces;
using ApiCatalog.Application.Services;
using ApiCatalog.Infrastructure.Data.Repositories;

namespace ApiCatalog.Infrastructure.Configurations;

public static class DependencyInjection
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        // Repositories
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        // Services
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
    }
}