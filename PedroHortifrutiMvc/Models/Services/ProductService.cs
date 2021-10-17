using PedroHortifrutiMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedroHortifrutiMvc.Models.Services
{
    public class ProductService
    {
        private readonly PedroHortifrutiMvcContext _context;

        public ProductService(PedroHortifrutiMvcContext context)
        {
            _context = context;
        }

        public List<Product> ListProducts()
        {
            return _context.Product.ToList();
        }
    }
}
