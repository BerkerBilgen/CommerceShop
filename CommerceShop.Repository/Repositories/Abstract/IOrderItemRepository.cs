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
    public interface IOrderItemRepository
    {
        Task<Result> CreateOrderItem(CreateOrderItemDTO createOrderItemDto);

        Task<Result> UpdateOrderItem(UpdateOrderItemDto updateOrderItemDto);

        Task<OrderItemDto> GetOrderItem(Guid orderItemId);

        Task<List<OrderItemDto>> GetOrderItemList();

    }
}
