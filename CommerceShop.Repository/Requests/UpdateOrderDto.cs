using CommerceShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Requests
{
    public class UpdateOrderDto
    {
        public Guid OrderId { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderStatus { get; set; }
    }
}
