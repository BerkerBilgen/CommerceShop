using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class OrderItem : Base
    {
        public int OrderItemCode { get; set; }
        public Guid FKOrderId { get; set; }
        public Order FKOrder { get; set; }
        public IList<Product> Products { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public int OrderItemStatus { get; set; }
        public int DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime DeliveryStartDate { get; set; }
        public string OrderNote { get; set; }
        public bool IsGift { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
        public Guid FKCargoCompanyId { get; set; }
        public CargoCompany FKCargoCompany { get; set; }
        public IList<Complaint> Complaints { get; set; }
    }
}
