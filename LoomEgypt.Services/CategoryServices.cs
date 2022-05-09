using AutoMapper;
using LoomEgypt.Domain.DTOs.Category;
using LoomEgypt.Domain.Entities;
using LoomEgypt.Domain.Interfaces.IServices;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoomEgypt.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IRepositories _repositories;
        private readonly IMapper _mapper;

        public CategoryServices(IRepositories repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public async Task<CategoryProductDisplayDTO> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO)
        {
            Category category = _mapper.Map<Category>(categoryCreateDTO);
            await _repositories.CategoryRepository.AddAsync(category);
            await _repositories.SaveAsync();
            return _mapper.Map<CategoryProductDisplayDTO>(category);
        }

        public async Task<IEnumerable<CategoryDisplayDTO>> GetAllAsync()
        {
            var categories = await _repositories.CategoryRepository.GetAllAsync();
            var categoriesDTO = _mapper.Map<IEnumerable<CategoryDisplayDTO>>(categories);
            return categoriesDTO;
        }

        public async Task<CategoryProductDisplayDTO> GetByIdAsync(int id, int? count)
        {
            if (count != null && count <= 0) 
                throw new ArgumentOutOfRangeException("[count] paramter should be positive");

            var category = await _repositories.CategoryRepository.GetCategoryByIDAsync(id);

            if (count.HasValue)
                category.Products = category.Products.Take(count.Value).ToList();

            var categoryDTO = _mapper.Map<CategoryProductDisplayDTO>(category);
            
            return categoryDTO;
        }
    }
}
