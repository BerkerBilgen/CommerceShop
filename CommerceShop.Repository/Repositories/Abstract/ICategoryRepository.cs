using CommerceShop.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        Task Create(CreateCategoryDto createCategoryDto);

        Task Update(UpdateCategoryDto updateCategoryDto);

        Task Delete(Guid cateogryId);
        Task<CategoryDto> GetCategory(Guid categoryId);

        Task<CategoryDto> GetCategoryList();
    }
}
