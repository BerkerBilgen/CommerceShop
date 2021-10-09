using CommerceShop.Data;
using CommerceShop.Data.Entities;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CommerceDbContext _commerceDbContext;

        public CategoryRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public async Task Create(CreateCategoryDto createCategoryDto)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Description = createCategoryDto.Description,
                IsActive = true,
                Name = createCategoryDto.Name,
                Products = createCategoryDto.Products
            };

            _commerceDbContext.Categories.Add(category);

            await _commerceDbContext.SaveChangesAsync();

        }

        public async Task Delete(Guid cateogryId)
        {
            var category = new Category()
            {
                Id = cateogryId,
                IsActive = false
            };

            _commerceDbContext.Categories.Add(category);

            await _commerceDbContext.SaveChangesAsync();
        }

        public Task<CategoryDto> GetCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryList()
        {
            throw new NotImplementedException();
        }

        public async Task Update(UpdateCategoryDto updateCategoryDto)
        {
            var category = new Category()
            {
                Id = updateCategoryDto.CategoryId,
                ModifiedOn = DateTime.Now,
                Description = updateCategoryDto.Description,
                IsActive = true,
                Name = updateCategoryDto.Name,
                Products = updateCategoryDto.Products
            };

            _commerceDbContext.Categories.Add(category);

            await _commerceDbContext.SaveChangesAsync();
        }
    }
}
