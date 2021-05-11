using Microsoft.EntityFrameworkCore;
using Code_.Models;

namespace Code_.Data
{
    public class MvcQuestContext : DbContext
    {
        public MvcQuestContext(DbContextOptions<MvcQuestContext> options)
: base(options)
        {
        }
        public DbSet<Quest> Quest { get; set; }
    }
}
