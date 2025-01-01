using ApiCatalog.Application.DTOs;
using ApiCatalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalog.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        var products = await _service.GetProductsAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> GetProduct(Guid id)
    {
        var product = await _service.GetProductByIdAsync(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateProduct(ProductDto productDto)
    {
        var productId = await _service.CreateProductAsync(productDto);
        return CreatedAtRoute("GetProduct", new { id = productId }, productId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateProduct(Guid id, ProductDto productDto)
    {
        await _service.UpdateProductAsync(id, productDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(Guid id)
    {
        await _service.DeleteProductAsync(id);
        return NoContent();
    }
}