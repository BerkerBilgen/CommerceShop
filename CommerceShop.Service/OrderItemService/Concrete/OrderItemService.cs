using CommerceShop.Common.Result;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Repositories.Abstract;
using CommerceShop.Repository.Requests;
using CommerceShop.Service.OrderItemService.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommerceShop.Service.OrderItemService.Concrete
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public async Task<Result> CreateOrderItemAsync(CreateOrderItemDTO createOrderItemDTO)
        {
            var result = await _orderItemRepository.CreateOrderItem(createOrderItemDTO);
            if (!result.IsSuccess)
                throw new Exception("Creation Has Failed");

            return result;
        }

        public async Task<Result> UpdateOrderItemAsync(UpdateOrderItemDto updateOrderItemDto)
        {
            var result = await _orderItemRepository.UpdateOrderItem(updateOrderItemDto);
            if (!result.IsSuccess)
                throw new Exception("Update Has Failed");

            return result;
        }

        public async Task<OrderItemDto> GetOrderItemAsync(Guid orderItemId)
        {
            var result = await _orderItemRepository.GetOrderItem(orderItemId);
            if (result == null)
                throw new Exception("No Order Item Has Found");

            return result; 
        }

        public async Task<List<OrderItemDto>> GetOrderItemListAsync()
        {
            var result = await _orderItemRepository.GetOrderItemList();

            if (result == null)
                throw new Exception("No Record Found");

            return result;
        }
    }
}
