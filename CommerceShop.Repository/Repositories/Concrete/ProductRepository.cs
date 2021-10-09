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
    public class ProductRepository : IProductRepository
    {

        private readonly CommerceDbContext _commerceDbContext;

        public ProductRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Description = createProductDto.Description,
                Categories = createProductDto.Categories,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                StockCount = createProductDto.StockCount,
                IsActive = true
            };

            _commerceDbContext.Products.Add(product);

            await _commerceDbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(Guid productId)
        {
            var product = new Product()
            {
                Id = productId,
                IsActive = false
            };
            _commerceDbContext.Products.Add(product);

            await _commerceDbContext.SaveChangesAsync();
        }

        public async Task<ProductDto> GetProduct(Guid productId)
        {
            return _commerceDbContext.Products.Where(x => x.Id == productId).Select(x => new ProductDto()
            {
                ProductId = x.Id,
                Categories = x.Categories,
                Description = x.Description,
                Price = x.Price,
                ProductName = x.ProductName,
                StockCount = x.StockCount
            }).FirstOrDefault();
        }

        public async Task<List<ProductDto>> GetProductList()
        {
            return _commerceDbContext.Products.Select(x => new ProductDto()
            {
                ProductId = x.Id,
                Categories = x.Categories,
                Description = x.Description,
                Price = x.Price,
                ProductName = x.ProductName,
                StockCount = x.StockCount
            }).ToList();
        }

        public async Task UpdateProduct(UpdateProductDto updateProductDto)
        {
            var product = new Product()
            {
                Id = updateProductDto.ProductId,
                Categories = updateProductDto.Categories,
                ModifiedOn = DateTime.Now,
                Description = updateProductDto.Description,
                IsActive = updateProductDto.IsActive,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                StockCount = updateProductDto.StockCount,
            };

            _commerceDbContext.Products.Add(product);

            await _commerceDbContext.SaveChangesAsync();
        }
    }
}
