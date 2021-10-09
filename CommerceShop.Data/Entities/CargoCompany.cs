using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data.Entities
{
    public class CargoCompany : Base
    {
        public int CargoCompanyCode { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
    }
}
