﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public record Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int InitialStock { get; set; }
        public int CurrentStock { get; set; }
        public decimal Price { get; set; }
        public bool IsSale { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
