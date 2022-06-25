using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(25)]
        public string Name { get; set; } = null!;

        public int LocationRefId { get; set; }

        [ForeignKey(nameof(LocationRefId))]

        public Location? LocationRef { get; set; } = null!;

        [Unicode(false)]
        [StringLength(15)]
        public string Type { get; set; } = null!;
    }
}
