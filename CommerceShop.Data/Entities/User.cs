using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid FKRoleId { get; set; }
        public Role Role { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string PersonalImage { get; set; }
        public int Status { get; set; }
    }
}
