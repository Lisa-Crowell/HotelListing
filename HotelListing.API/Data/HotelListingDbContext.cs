using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data;

public class HotelListingDbContext : DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "Ireland",
                ShortName = "IE"
            },
            new Country
            {
                Id = 2,
                Name = "United Kingdom",
                ShortName = "UK"
            },
            new Country
            {
                Id = 3,
                Name = "Scotland",
                ShortName = "SC"
            });
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Brazen Head",
                CountryId = 1,
                Address = "Dublin",
                Rating = 5
            },
            new Hotel
            {
                Id = 2,
                Name = "King's Head",
                CountryId = 2,
                Address = "London",
                Rating = 4
            },
            new Hotel
            {
                Id = 3,
                Name = "Edinburgh Castle Hotel",
                CountryId = 3,
                Address = "Edinburgh",
                Rating = 4.5
            });
    }
    
}