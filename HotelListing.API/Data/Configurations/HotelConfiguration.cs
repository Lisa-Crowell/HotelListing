using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.HasData(
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