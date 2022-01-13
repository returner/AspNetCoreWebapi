using Api.Controllers;
using Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiTest
{
    public class ProductsControllerTest
    {
        [Fact]
        public async Task GetProductsAsync()
        {
            var mockSet = new Mock<DbSet<Product>>();
            //mockContext.Setup(context => context.Products).Returns(GetTestProducts());
            var data = GetTestProducts();
            mockSet.As<IQueryable<Product>>().Setup(p => p.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Product>>().Setup(p => p.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Product>>().Setup(p => p.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Product>>().Setup(p => p.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ShopMockContext>();
            mockContext.Setup(c => c.Products).Returns(mockSet.Object);

            var productController = new ProductsController(mockContext.Object);

            var result = await productController.GetProducts();
            Assert.NotNull(result);
        }

        private ShopContext GetTestShopContext()
        {
            var context = new ShopContext();
            for (int i = 0; i < 5; i++)
            {
                context.Products.Add(new Product { Name = Guid.NewGuid().ToString(), Count = 1, CreateDateTime = DateTime.UtcNow });
                context.Carts.Add(new Cart { Name = Guid.NewGuid().ToString(), CreateDateTime = DateTime.UtcNow });
            }
            return context;
        }

        private IQueryable<Product> GetTestProducts()
        {
            var result = new List<Product>();
            for (int i = 0; i < 5; i++)
            {
                result.Add(new Product { Name = Guid.NewGuid().ToString(), Count = 1, CreateDateTime = DateTime.UtcNow });
            }
            return result.AsQueryable();
        }
    }
}
