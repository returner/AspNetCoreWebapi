using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public record Cart
    {
        public int Id { get; set; }
        public User User { get; set; } = null!;
        public ICollection<CartItem>? Items { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
