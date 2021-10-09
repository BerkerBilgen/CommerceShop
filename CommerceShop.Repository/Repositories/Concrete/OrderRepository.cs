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
    public class OrderRepository : IOrderRepository
    {
        private readonly CommerceDbContext _dbContext;
        public OrderRepository(CommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Result> CreateOrder(CreateOrderDto createOrderRequest)
        {
            var result = new Result();
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                FKCustomer = createOrderRequest.FKCustomer,
                Bill = createOrderRequest.Bill,
                CreatedOn = DateTime.Now,
                IsActive = true,
                OrderCreationDate = DateTime.Now,
                OrderItems = createOrderRequest.OrderItems,
                OrderStatus = (int)OrderStatus.New,
                PaymentType = createOrderRequest.PaymentType,
                TotalPrice = createOrderRequest.TotalPrice
            };

            _dbContext.Orders.Add(order);

            await _dbContext.SaveChangesAsync();
            result.IsSuccess = true;
            result.Message = "Created Successfully";

            return result;
        }

        public async Task<Result> DeleteOrder(Guid orderId)
        {
            var result = new Result();
            var order = new Order()
            {
                Id = orderId,
                IsActive = false,
                OrderStatus = (int)OrderStatus.Cancelled
            };

            _dbContext.Orders.Add(order);

            await _dbContext.SaveChangesAsync();

            result.IsSuccess = true;
            result.Message = "Deleted Successfully";

            return result;
        }

        public async Task<OrderDTO> GetOrder(Guid orderId)
        {
            return _dbContext.Orders.Where(x => x.Id == orderId).Select(x => new OrderDTO()
            {
                OrderId = x.Id,
                Bill = x.Bill,
                FKCustomer = x.FKCustomer,
                OrderCreationDate = x.OrderCreationDate,
                OrderItems = x.OrderItems,
                OrderStatus = x.OrderStatus,
                PaymentType = x.PaymentType,
                TotalPrice = x.TotalPrice
            }).FirstOrDefault();
        }

        public async Task<List<OrderDTO>> GetOrderList()
        {
            return _dbContext.Orders.Select(x => new OrderDTO()
            {
                OrderId = x.Id,
                FKCustomer = x.FKCustomer,
                FKCustomerId = x.FKCustomerId,
                Bill = x.Bill,
                FKBillId = x.FKBillId,
                OrderCreationDate = x.OrderCreationDate,
                OrderStatus = x.OrderStatus,
                OrderItems = x.OrderItems,
                PaymentType = x.PaymentType,
                TotalPrice = x.TotalPrice
            }).ToList();

        }

        public async Task<Result> UpdateOrder(UpdateOrderDto updateOrderRequest)
        {
            var result = new Result();
            var order = new Order()
            {
                Id = updateOrderRequest.OrderId,
                OrderStatus = updateOrderRequest.OrderStatus,
                TotalPrice = updateOrderRequest.TotalPrice,
                OrderItems = updateOrderRequest.OrderItems
            };

            _dbContext.Orders.Add(order);

            await _dbContext.SaveChangesAsync();

            result.IsSuccess = true;
            result.Message = "Updated Successfully";

            return result;
        }
    }
}
