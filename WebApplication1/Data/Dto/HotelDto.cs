using WebApplication1.Data.Models;

namespace WebApplication1.Data.Dto
{
    public class HotelDto
    {
        public string Name { get; set; } = null!;

        public int LocationRefId { get; set; }

        public Location LocationRef { get; set; } = null!;

        public string Type { get; set; } = null!;
    }
}
