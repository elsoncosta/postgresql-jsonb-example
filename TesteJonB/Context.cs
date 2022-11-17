using Microsoft.EntityFrameworkCore;

using TesteJonB.Models;

namespace TesteJonB
{
    public class Context : DbContext
    {
        public Context()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            // AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            Database.Migrate();
        }
        public DbSet<SomeEntity> SomeEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=localhost:5432;Username=postgres;Password=123123;Database=mydatabase");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SomeEntity>()
                .Property(b => b.Customer)
                .HasColumnType("jsonb");

            modelBuilder.Entity<SomeEntity>()
            .Property(b => b.DataTeste2)
            .HasColumnType("timestamp with time zone");

            modelBuilder.Entity<SomeEntity>()
            .Property(b => b.DataAutomatico)
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAdd();

             modelBuilder.Entity<SomeEntity>()
            .Property(b => b.DataAutomaticoUtc)
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAdd();
            
        }
    }
}