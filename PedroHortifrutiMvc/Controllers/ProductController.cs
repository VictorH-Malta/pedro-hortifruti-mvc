using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedroHortifrutiMvc.Models;
using PedroHortifrutiMvc.Data;
using PedroHortifrutiMvc.Models.Services;

namespace PedroHortifrutiMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var list = _productService.ListProducts();
            return View(list);
        }
    }
}
