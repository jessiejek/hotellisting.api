using hotellisting.api.Models.Hotel;

namespace hotellisting.api.Models.Country
{
    public class CountryDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Shortname { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }


}
