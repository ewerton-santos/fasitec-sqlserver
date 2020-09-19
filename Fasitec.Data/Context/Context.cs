using Fasitec.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fasitec.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet<User> Users { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
            .HasKey(k => k.UserId);
            modelBuilder.Entity<User>()
            .HasIndex(p => p.Email)
            .IsUnique();
            modelBuilder.Entity<User>()
            .Property(p => p.Email)
            .HasMaxLength(100)
            .IsRequired();            
        }
    }
}