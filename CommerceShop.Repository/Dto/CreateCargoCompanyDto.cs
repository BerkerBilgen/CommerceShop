using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Dto
{
    public class CreateCargoCompanyDto
    {
        public int CargoCompanyCode { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
    }
}
