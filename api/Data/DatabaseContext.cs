using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Australia",
                    ShortName = "AU"
                },
                new Country
                {
                    Id = 2,
                    Name = "New Zealand",
                    ShortName = "NZ"
                },
                new Country
                {
                    Id = 3,
                    Name = "Great Britain",
                    ShortName = "UK"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 5,
                    Address = "42 Russell St Melbourne",
                    Name = "Royal Plaza",
                    Rating = "5",
                    CountryId=1
                },
                new Hotel
                {
                    Id = 1,
                    Address = "101 Lonsdale St Melbourne",
                    Name = "The Big Hotel",
                    Rating = "4",
                    CountryId=1
                },
                new Hotel
                {
                    Id = 2,
                    Address = "55 Smith Rd Cantebury",
                    Name = "Kiwi Place",
                    Rating = "5",
                    CountryId=2
                },
                new Hotel
                {
                    Id = 3,
                    Address = "450 London Bvld London",
                    Name = "The Royal Oak",
                    Rating = "3",
                    CountryId=3
                },
                new Hotel
                {
                    Id = 4,
                    Address = "1000 Bridge Rd Newcastle",
                    Name = "Covid Place",
                    Rating = "4.4",
                    CountryId=1
                }
            );
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}