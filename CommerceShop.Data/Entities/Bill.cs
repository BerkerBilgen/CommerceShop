using System;
namespace CommerceShop.Data.Entities
{
    public class Bill : Base
    {
        public int BillCode { get; set; }
        public Customer Customer { get; set; }
        public Guid FKCustomerId { get; set; }
        public int PaymentType { get; set; }
        public Order FKOrder { get; set; }
        public Guid FKOrderId { get; set; }
    }
}
