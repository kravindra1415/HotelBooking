using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBooking : ControllerBase
    {
        private readonly IHotelService _hotelService;
        public HotelBooking(IHotelService hotelService)
        {
                _hotelService= hotelService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (_hotelService != null)
            {
                var hotel = _hotelService.GetAllAsync();
                return Ok(hotel);
            }
            return BadRequest();
                        
        }


    }
}
