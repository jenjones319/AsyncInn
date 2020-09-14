using AsyncInn.Models;
using ASyncInn.Models;
using Microsoft.EntityFrameworkCore;

namespace ASyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>()
                .HasData(
                    new Hotel { Id = 1, Name = "Async Inn", StreetAddress = "515 W. Burlington St", City = "Iowa City", State = "Iowa", Phone = "319 - 541 - 7504" },
                    new Hotel { Id = 2, Name = "Async Hotel", StreetAddress = "1216 Aurora Ln", City = "Moline", State = "Illinois", Phone = "630 - 772 - 1411" },
                    new Hotel { Id = 3, Name = "Async Spa", StreetAddress = "1984 Wasatch Pl", City = "St. Paul", State = "Minnesota", Phone = "612 - 424 - 2468" }
                );
            modelBuilder.Entity<Room>()
                .HasData(
                    new Room { Id = 1, Name = "Studio", Layout = "0br" },
                    new Room { Id = 2, Name = "OneBdr", Layout = "1br" },
                    new Room { Id = 3, Name = "TwoBdr", Layout = "2br" }
                );
            modelBuilder.Entity<Amenity>()
                 .HasData(
                    new Amenity { Id = 1, Name = "AC" },
                    new Amenity { Id = 2, Name = "Wireless" },
                    new Amenity { Id = 3, Name = "Coffee Maker" }
                );
            modelBuilder.Entity<HotelRoom>()
                .HasKey()
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }

    }
}
