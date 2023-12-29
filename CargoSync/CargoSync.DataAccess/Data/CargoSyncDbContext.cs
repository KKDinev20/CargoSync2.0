using CargoSync.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoSync.DataAccess
{
    public class CargoSyncDbContext : DbContext
    {
        public CargoSyncDbContext(DbContextOptions<CargoSyncDbContext> options)
            : base(options)
        {
        }

        public DbSet<Delivery> Deliveries { get; set; }
        // Add other DbSet properties for your entities...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Delivery entity
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

            // Configure relationships or additional entities...

            // Example: Configure a one-to-many relationship between Delivery and another entity
            // modelBuilder.Entity<AnotherEntity>()
            //     .HasMany(a => a.Deliveries)
            //     .WithOne(d => d.AnotherEntity)
            //     .HasForeignKey(d => d.AnotherEntityId);
        }
    }
}
