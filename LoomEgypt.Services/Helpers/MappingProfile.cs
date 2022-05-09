using AutoMapper;
using LoomEgypt.Domain.DTOs.Category;
using LoomEgypt.Domain.DTOs.Products;
using LoomEgypt.Domain.Entities;
using System.Collections.Generic;

namespace LoomEgypt.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductAttribute, ProductAttributeDisplayDTO>();
            CreateMap<ProductAttributeItem, ProductAttributeItemDisplayDTO>();
            CreateMap<ProductImage, ProductImageDisplayDTO>();
            CreateMap<Product, ProductDisplayDTO>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.AvailableQuantity, opt => opt.MapFrom(src => src.ProductInventory.Quantity))
                .ForMember(dest => dest.inStock, opt => opt.MapFrom(src => src.ProductInventory.Quantity > 0 ? true : false));



            CreateMap<Category, CategoryDisplayDTO>();
            CreateMap<Category, CategoryProductDisplayDTO>();
            CreateMap<CategoryCreateDTO, Category>();
        }
    }
}
