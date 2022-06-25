using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
