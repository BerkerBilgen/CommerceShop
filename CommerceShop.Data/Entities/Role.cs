using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class Role : Base
    {
        public int RoleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid FKUserId { get; set; }
        public IList<User> Users { get; set; }
    }
}
