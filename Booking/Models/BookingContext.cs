using Microsoft.EntityFrameworkCore;

namespace Booking.Models
{
    public class BookingContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<NonHotel> NonHotels { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.;Database=Booking;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                        .HasOne(b => b.Room)
                        .WithMany(r => r.Bookings)
                        .HasForeignKey(b => b.RoomID)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
                        .Property(p => p.Amount)
                        .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Room>()
                        .Property(r => r.PriceForNight)
                        .HasColumnType("decimal(18, 2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
