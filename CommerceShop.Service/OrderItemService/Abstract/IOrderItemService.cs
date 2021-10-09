using CommerceShop.Common.Result;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Service.OrderItemService.Abstract
{
    public interface IOrderItemService
    {
        Task<Result> CreateOrderItemAsync(CreateOrderItemDTO createOrderItemDTO);

        Task<Result> UpdateOrderItemAsync(UpdateOrderItemDto updateOrderItemDto);

        Task<OrderItemDto> GetOrderItemAsync(Guid orderItemId);

        Task<List<OrderItemDto>> GetOrderItemListAsync();
    }
}
