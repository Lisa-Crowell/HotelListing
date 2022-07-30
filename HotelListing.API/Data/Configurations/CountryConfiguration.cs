using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasData(
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
    }
}