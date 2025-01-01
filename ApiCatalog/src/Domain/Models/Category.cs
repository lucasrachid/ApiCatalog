using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalog.Domain.Models;

[Table("Categories")]
public class Category
{
    public Category(string name, string description)
    {   
        Id = Guid.NewGuid();
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        Products = new Collection<Product>();
        CreatedAt = DateTime.UtcNow;
    }
    
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [StringLength(200, ErrorMessage = "Name cant be longer than 200 characters.")]
    public string Name { get; set; }
    
    [Required]
    [StringLength(500, ErrorMessage = "Description cant be longer than 500 characters.")]
    public string Description { get; set; }
    
    [Required]
    [StringLength(255, ErrorMessage = "Description cant be longer than 255 characters.")]
    public string? ImageUrl { get; set; }
    
    public DateTime CreatedAt { get; init; }
    
    public ICollection<Product>? Products { get; set; }
}