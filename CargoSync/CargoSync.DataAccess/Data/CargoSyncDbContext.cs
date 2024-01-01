// CargoSync.DataAccess.Data.CargoSyncDbContext
using CargoSync.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoSync.DataAccess.Data
{
    public class CargoSyncDbContext : DbContext
    {
        public CargoSyncDbContext(DbContextOptions<CargoSyncDbContext> options)
            : base(options)
        {
        }

        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Delivery>()
                .HasKey(d => d.DeliveryID);

            modelBuilder.Entity<Delivery>()
                .Property(d => d.Destination)
                .IsRequired();

            modelBuilder.Entity<Delivery>()
                .Property(d => d.ETA)
                .IsRequired();

            modelBuilder.Entity<Delivery>()
                .Property(d => d.Status)
                .IsRequired();

            modelBuilder.Entity<Cargo>()
                .HasKey(c => c.CargoID);

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Description)
                .IsRequired();

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Quantity)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
