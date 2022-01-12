using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public record Cart
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
