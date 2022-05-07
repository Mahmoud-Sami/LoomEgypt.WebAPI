using AutoMapper;
using LoomEgypt.Domain.DTOs.Category;
using LoomEgypt.Domain.Interfaces.IServices;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using System;
using System.Collections.Generic;
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

        public Task<bool> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryDisplayDTO>> GetAllAsync()
        {
            var categories = await _repositories.CategoryRepository.GetAllAsync(x => x.Products);
            var categoriesDTO = _mapper.Map<IEnumerable<CategoryDisplayDTO>>(categories);
            return categoriesDTO;
        }

        public async Task<CategoryProductDisplayDTO> GetByIdAsync(int id)
        {
            var category = await _repositories.CategoryRepository.GetCategoryByIDAsync(id);
            var categoryDTO = _mapper.Map<CategoryProductDisplayDTO>(category);
            return categoryDTO;
        }
    }
}
