using CommerceShop.Common.Result;
using CommerceShop.Data.Entities;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Requests;
using CommerceShop.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Abstract
{
    public interface IOrderRepository
    {
        Task<Result> CreateOrder(CreateOrderDto createOrderRequest);
        Task<Result> UpdateOrder(UpdateOrderDto updateOrderRequest);
        Task<Result> DeleteOrder(Guid orderId);
        Task<List<OrderDTO>> GetOrderList();

        Task<OrderDTO> GetOrder(Guid orderId);
    }
}
