using CommerceShop.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Abstract
{
    public interface IProductRepository
    {
        Task CreateProduct(CreateProductDto createProductDto);

        Task UpdateProduct(UpdateProductDto updateProductDto);


        Task DeleteProduct(Guid productId);

        Task<ProductDto> GetProduct(Guid productId);

        Task<List<ProductDto>> GetProductList();

    }
}
