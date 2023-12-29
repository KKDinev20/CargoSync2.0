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

        }
    }
}
