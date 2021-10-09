using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class Complaint
    {
        public Guid Id { get; set; }
        public int CompaintCode { get; set; }
        public Guid FKCustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid FKOrderItemId { get; set; }
        public OrderItem FKOrderItem { get; set; }
        public int Status { get; set; }
    }
}
