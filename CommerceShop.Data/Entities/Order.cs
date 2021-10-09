using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class Order : Base
    {
        public int OrderCode{ get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderStatus { get; set; }
        public Guid FKCustomerId { get; set; }
        public Customer FKCustomer { get; set; }
        public DateTime OrderCreationDate { get { return OrderCreationDate; } set { OrderCreationDate = DateTime.Now; } }
        public int PaymentType { get; set; }

        public Bill Bill { get; set; }
        public Guid FKBillId { get; set; }
    }
}
