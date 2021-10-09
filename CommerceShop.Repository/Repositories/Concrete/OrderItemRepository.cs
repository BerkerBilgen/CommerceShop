using CommerceShop.Common.Result;
using CommerceShop.Data;
using CommerceShop.Data.Entities;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Repositories.Abstract;
using CommerceShop.Repository.Requests;
using CommerceShop.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommerceShop.Common.Enum.Enum;

namespace CommerceShop.Repository.Repositories.Concrete
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly CommerceDbContext _dbContext;

        public OrderItemRepository(CommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Result> CreateOrderItem(CreateOrderItemDTO createOrderItemDto)
        {
            var result = new Result();
            var orderItem = new OrderItem()
            {
                Address = createOrderItemDto.Address,
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Amount = createOrderItemDto.Amount,
                FKCargoCompanyId = createOrderItemDto.FKCargoCompanyId,
                IsActive = true,
                OrderItemStatus = (int)OrderItemStatus.New,
                OrderNote = createOrderItemDto.OrderNote,
                IsGift = createOrderItemDto.IsGift,
                Quantity = createOrderItemDto.Quantity,
                DiscountAmount = createOrderItemDto.DiscountAmount,
                DiscountPercentage = createOrderItemDto.DiscountPercentage
            };

            _dbContext.OrderItems.Add(orderItem);

            await _dbContext.SaveChangesAsync();

            result.IsSuccess = true;
            result.Message = "Successfully Created";

            return result;
        }

        public async Task<OrderItemDto> GetOrderItem(Guid orderItemId)
        {
            return  _dbContext.OrderItems.Where(x => x.Id == orderItemId).Select(x =>  new OrderItemDto() { 
            Address = x.Address,
            Amount = x.Amount,
            DeliveryDate = x.DeliveryDate,
            Complaints = x.Complaints,
            DeliveryStartDate = x.DeliveryStartDate,
            DiscountAmount = x.DiscountAmount,
            DiscountPercentage = x.DiscountPercentage,
            FKCargoCompany = x.FKCargoCompany,
            FKCargoCompanyId = x.FKCargoCompanyId,
            FKOrder = x.FKOrder,
            FKOrderId = x.FKOrderId,
            IsGift = x.IsGift,
            OrderItemId = x.Id,
            OrderItemStatus = x.OrderItemStatus,
            OrderNote = x.OrderNote,
            Products = x.Products,
            Quantity = x.Quantity
            }).FirstOrDefault();
        }

        public async Task<List<OrderItemDto>> GetOrderItemList()
        {
            return _dbContext.OrderItems.Where(x => x.IsActive == true).Select(x => new OrderItemDto()
            {
                Address = x.Address,
                Amount = x.Amount,
                DeliveryDate = x.DeliveryDate,
                Complaints = x.Complaints,
                DeliveryStartDate = x.DeliveryStartDate,
                DiscountAmount = x.DiscountAmount,
                DiscountPercentage = x.DiscountPercentage,
                FKCargoCompany = x.FKCargoCompany,
                FKCargoCompanyId = x.FKCargoCompanyId,
                FKOrder = x.FKOrder,
                FKOrderId = x.FKOrderId,
                IsGift = x.IsGift,
                OrderItemId = x.Id,
                OrderItemStatus = x.OrderItemStatus,
                OrderNote = x.OrderNote,
                Products = x.Products,
                Quantity = x.Quantity
            }).ToList();
        }

        public async Task<Result> UpdateOrderItem(UpdateOrderItemDto updateOrderItemDto)
        {
            var orderItem = new OrderItem()
            {
                Address = updateOrderItemDto.Address,
                Id = Guid.NewGuid(),
                FKOrderId = updateOrderItemDto.FKOrderId,
                FKOrder = updateOrderItemDto.FKOrder,
                CreatedOn = DateTime.Now,
                Amount = updateOrderItemDto.Amount,
                FKCargoCompanyId = updateOrderItemDto.FKCargoCompanyId,
                IsActive = updateOrderItemDto.IsActive,
                OrderItemStatus = updateOrderItemDto.OrderItemStatus,
                OrderNote = updateOrderItemDto.OrderNote,
                IsGift = updateOrderItemDto.IsGift,
                Quantity = updateOrderItemDto.Quantity,
                DiscountAmount = updateOrderItemDto.DiscountAmount,
                DiscountPercentage = updateOrderItemDto.DiscountPercentage,
                ModifiedOn = DateTime.Now
            };

            _dbContext.OrderItems.Add(orderItem);

            await _dbContext.SaveChangesAsync();

            var result = new Result();

            result.Message = "Successfully Updated";
            result.IsSuccess = true;

            return result;
        }
    }
}
