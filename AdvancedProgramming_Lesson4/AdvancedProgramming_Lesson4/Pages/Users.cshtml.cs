using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdvancedProgramming_Lesson4.Pages
{
    
    public class UsersModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public UsersModel(ApplicationDbContext context)
        {
            this.context = context;
        }
       // public IList<User> User { get; set; }
        public void OnGet()
        {
            //User = context.Users.ToList();
        }
    }
}
