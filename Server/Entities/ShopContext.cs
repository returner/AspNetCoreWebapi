using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ShopContext : DbContext, IShopContext
    {
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        public ShopContext()
        {

        }
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

    }

    public class ShopMockContext : DbContext, IShopContext
    {
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        public ShopMockContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
    }

    public interface IShopContext
    {
        DbSet<Cart> Carts { get; set;}
        DbSet<Product> Products { get; set;}
    }
}
