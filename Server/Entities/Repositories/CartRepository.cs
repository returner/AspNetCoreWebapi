using Entities;
using Microsoft.EntityFrameworkCore;

namespace SharedModels.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ShopContext _context;
        public CartRepository(ShopContext shopContext)
        {
            _context = shopContext;
        }

        public Cart GetCartById(int cartId)
        {
            return _context.Carts.FirstOrDefault(d => d.Id.Equals(cartId));
        }

        public IEnumerable<Cart> GetCarts()
        {
            return _context.Carts.ToList();
        }
        public void InsertCart(Cart cart)
        {
            _context.Carts.Add(cart);
        }
        public void DeleteCart(int cartId)
        {
            _context.Carts.Remove(GetCartById(cartId));
        }

        public void UpdateCart(Cart cart)
        {
            _context.Entry(cart).State = EntityState.Modified;
        }
    }
}
