using CargoSync.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

// Database context class for CargoSync application
namespace CargoSync.DataAccess.Data
{
    public class CargoSyncDbContext : DbContext
    {
        // Constructor to initialize the context with options
        public CargoSyncDbContext(DbContextOptions<CargoSyncDbContext> options)
            : base(options)
        {
        }

        // DbSet properties representing database tables
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Revenue> Revenue { get; set; }

        // Method to configure entity relationships and constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Delivery entity configuration
            modelBuilder.Entity<Delivery>()
                .HasKey(d => d.DeliveryId);

            modelBuilder.Entity<Delivery>()
                .Property(d => d.Destination)
                .IsRequired();

            modelBuilder.Entity<Delivery>()
                .Property(d => d.ETA)
                .IsRequired();

            modelBuilder.Entity<Delivery>()
                .Property(d => d.Status)
                .IsRequired();

            // Cargo entity configuration
            modelBuilder.Entity<Cargo>()
                .HasKey(c => c.CargoId);

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Description)
                .IsRequired();

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Quantity)
                .IsRequired();

            // User entity configuration
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<User>()
                .Property(u => u.UserName)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.UserType)
                .IsRequired();

            // Revenue entity configuration
            modelBuilder.Entity<Revenue>()
                .HasKey(r => r.RevenueId);

            modelBuilder.Entity<Revenue>()
                .Property(r => r.Amount)
                .IsRequired()
                .HasPrecision(18, 2);

            modelBuilder.Entity<Revenue>()
                .Property(r => r.Month)
                .IsRequired();

            // Call the base class method
            base.OnModelCreating(modelBuilder);
        }
    }
}
