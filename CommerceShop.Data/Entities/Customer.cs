using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class Customer : Base
    {
        public int CustomerCode { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MemberShiptDate { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Complaint> Complaints { get; set; }
        public string Password { get; set; }
    }
}
