using AutoMapper;
using WebApplication1.Data.Dto;
using WebApplication1.Data.Models;

namespace WebApplication1
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
