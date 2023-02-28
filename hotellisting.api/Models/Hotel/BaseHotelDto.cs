using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace hotellisting.api.Models.Hotel
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adrress { get; set; }
        public double? Rating { get; set; }

        [Required]
        [Range(1,int.MaxValue)]
        public int CountryId { get; set; }
    }
}
