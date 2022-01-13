using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels.Repositories;

namespace Api.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        public ProductsController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpGet("GetProducts")]
        public async Task<IEnumerable<Product>?> GetProducts()
        {
            //var result = await _shopContext.Products.ToArrayAsync();

            //if (result == null || !result.Any())
            //{
            //    return null;
            //}

            //return result;
            await Task.CompletedTask;
            return new List<Product>();
        }

        public async Task<IEnumerable<Cart>> GetCartsAsync()
        {
            await Task.CompletedTask;
            return _cartRepository.GetCarts();
        }
    }
}
