using CommerceShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Dto
{
    public class CreateBillDto
    {
        public Guid BillId { get; set; }
        public int BillCode { get; set; }
        public Customer Customer { get; set; }
        public Guid FKCustomerId { get; set; }
        public int PaymentType { get; set; }
        public Order FKOrder { get; set; }
        public Guid FKOrderId { get; set; }
    }
}
