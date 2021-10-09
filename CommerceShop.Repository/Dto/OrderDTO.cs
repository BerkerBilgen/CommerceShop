using CommerceShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Dto
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public int OrderCode { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderStatus { get; set; }
        public Guid FKCustomerId { get; set; }
        public Customer FKCustomer { get; set; }
        public DateTime OrderCreationDate { get; set; }
        public int PaymentType { get; set; }
        public Bill Bill { get; set; }
        public Guid FKBillId { get; set; }
    }
}
}
