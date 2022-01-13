using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Repositories
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetCarts();
        Cart GetCartById(int cartId);
        void InsertCart(Cart cart);
        void DeleteCart(int cartId);
        void UpdateCart(Cart cart);
    }
}
