namespace hotellisting.api.Models.Hotel
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adrress { get; set; }
        public double Rating { get; set; }
        public int CountryId { get; set; }
    }
}
