using PedroHortifrutiMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedroHortifrutiMvc.Models.Services
{
    public class CartService
    {
        private readonly PedroHortifrutiMvcContext _context;

        public CartService(PedroHortifrutiMvcContext context)
        {
            _context = context;
        }

        //public async Task FindAllAsync
        public async Task<Cart> CreateCart(CartProduct[] cartProduct)
        {
            Cart cart = new Cart() { CreatedAt = DateTime.Now };
            _context.Set<Cart>().Add(cart);
            await _context.SaveChangesAsync();

            List<CartProduct> cartProductList = new List<CartProduct>();
            foreach (var prod in cartProduct)
            {
                cartProductList.Add(new CartProduct { CartId = cart.Id, ProductId = prod.ProductId, Quantity = prod.Quantity });
            }

            _context.Set<CartProduct>().AddRange(cartProductList);
            await _context.SaveChangesAsync();
            return cart;
        }
    }
}
