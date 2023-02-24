using Microsoft.EntityFrameworkCore;

namespace hotellisting.api.Data
{
    public class HotelListingDbContext :DbContext
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
                            Name = "Jamaica",
                            Shortname = "JM"
                        },new Country
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
                    modelBuilder.Entity<Hotel>().HasData(
                        new Hotel
                        {
                            Id = 1,
                            Name = "Sandals Resort and Spa",
                            Adrress = "Negril",
                            CountryId =1,
                            Rating=4.5
                        }, new Hotel
                        {
                            Id = 2,
                            Name = "Comfort Suites",
                            Adrress = "George Town",
                            CountryId = 3,
                            Rating = 4.3
                        }, new Hotel
                        {
                            Id = 3,
                            Name = "Grand Palldium",
                            Adrress = "NAssua",
                            CountryId = 2,
                            Rating = 4
                        }
                    );
                }
    }
}
