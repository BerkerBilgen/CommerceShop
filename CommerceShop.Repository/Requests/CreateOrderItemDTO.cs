using CommerceShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Requests
{
    public class CreateOrderItemDTO
    {
        public IList<Product> Products { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime DeliveryStartDate { get; set; }
        public string OrderNote { get; set; }
        public bool IsGift { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
        public Guid FKCargoCompanyId { get; set; }
        public CargoCompany FKCargoCompany { get; set; }
        public decimal Amount { get; set; }
    }
}
