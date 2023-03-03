using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotellisting.api.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {

            builder.HasData(
                        new Country
                        {
                            Id = 1,
                            Name = "Jamaica",
                            Shortname = "JM"
                        }, new Country
                        {
                            Id = 2,
                            Name = "Bahamas",
                            Shortname = "BS"
                        }, new Country
                        {
                            Id = 3,
                            Name = "Cayman Island",
                            Shortname = "CI"
                        }
                    );
        }
    }
}
