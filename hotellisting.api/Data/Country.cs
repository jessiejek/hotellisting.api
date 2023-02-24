namespace hotellisting.api.Data
{
    public class Country
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Shortname { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}