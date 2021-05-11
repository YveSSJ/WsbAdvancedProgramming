using Microsoft.EntityFrameworkCore;
using Code_.Models;

namespace Code_.Data
{
    public class MvcAbilityContext : DbContext
    {
        public MvcAbilityContext(DbContextOptions<MvcAbilityContext> options)
: base(options)
        {
        }
        public DbSet<Ability> Ability { get; set; }
    }
}
