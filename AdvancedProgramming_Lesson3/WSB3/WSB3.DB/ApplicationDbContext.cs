using Microsoft.EntityFrameworkCore;
using System;
using WSB3.Domain;

namespace WSB3.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<PersonEntity> PersonEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PersonEntity>();
        }
    }
}
