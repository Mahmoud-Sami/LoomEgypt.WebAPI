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
            CreateMap<Category, CategoryDisplayDTO>().ReverseMap();
        }
    }
}
