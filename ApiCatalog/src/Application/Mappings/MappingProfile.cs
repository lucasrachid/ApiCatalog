using ApiCatalog.Application.DTOs;
using ApiCatalog.Domain.Models;
using AutoMapper;

namespace ApiCatalog.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}