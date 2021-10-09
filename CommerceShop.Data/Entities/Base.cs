using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class Base
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid UserId { get; set; }
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public bool IsActive { get; set; }
    }
}
