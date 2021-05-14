using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Entities
{
    public class User : IdentityUser<Guid>
    {
        public Doctor Doctor { get; set; }
        public Pacient Pacient { get; set; }
        public string RefreshToken { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
