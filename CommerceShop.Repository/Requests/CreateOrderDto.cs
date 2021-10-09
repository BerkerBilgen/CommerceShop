using CommerceShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Requests
{
    public class CreateOrderDto
    {
        public List<OrderItem> OrderItems { get; set; }
        public Guid FKCustomerId { get; set; }

        public Customer FKCustomer { get; set; }
        public Guid BillId { get; set; }
        public Bill Bill { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentType { get; set; }
    }
}
