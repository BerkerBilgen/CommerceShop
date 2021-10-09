using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Dto
{
    public class UpdateUserDto
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string PersonalImage { get; set; }
        public Guid RoleId { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
    }
}
