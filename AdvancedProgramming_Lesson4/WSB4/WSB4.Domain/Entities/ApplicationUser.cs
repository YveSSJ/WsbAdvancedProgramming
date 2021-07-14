using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB4.Domain
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }
    }
}
