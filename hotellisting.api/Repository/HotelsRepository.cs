using hotellisting.api.Contracts;
using hotellisting.api.Data;
using HotelListing.API.Repository;

namespace hotellisting.api.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
