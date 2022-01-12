using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ShopContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        public ShopContext()
        {

        }
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

    }
}
