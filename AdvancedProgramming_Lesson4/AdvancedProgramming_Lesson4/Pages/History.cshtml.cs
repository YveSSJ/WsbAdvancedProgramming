using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public HistoryModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IList<ChatMessage> Messages { get; set; }
        public void OnGet()
        {
            Messages = context.Messages.ToList();
        }

    }
}
