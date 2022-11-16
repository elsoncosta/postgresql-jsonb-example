using Microsoft.EntityFrameworkCore;

using TesteJonB.Models;

namespace TesteJonB
{
    public class Context : DbContext
    {
        public DbSet<SomeEntity> SomeEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=123123;Database=mydatabase");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SomeEntity>()
                .Property(b => b.Customer)
                .HasColumnType("jsonb");
        }
    }
}