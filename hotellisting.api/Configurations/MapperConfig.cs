using AutoMapper;
using hotellisting.api.Data;
using hotellisting.api.Models.Country;
using hotellisting.api.Models.Hotel;
using hotellisting.api.Models.Users;

namespace hotellisting.api.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel,HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap(); 
        }
    }
}
