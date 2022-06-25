using WebApplication1.Data.Dto;

namespace WebApplication1.Data.Services
{
    public interface IHotelService
    {
        Task<List<HotelDto>> GetAllAsync();
    }
}