using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PedroHortifrutiMvc.Data;
using PedroHortifrutiMvc.Models;
using PedroHortifrutiMvc.Models.Services;

namespace PedroHortifrutiMvc.Controllers
{
    [Route("/api/cart")]
    [ApiController]
    public class CartApiController : ControllerBase
    {
        private readonly CartService _cartService;

        public CartApiController(CartService cartService)
        {
            _cartService = cartService;
        }

        // GET: Cart
        //public async Task<IActionResult> Index()
        //{
        //    return View();
        //}


        [HttpPost]
        public async Task<ActionResult<Cart>> FinishCart([FromBody] CartProduct[] cartProduct)
        { 
            return Ok(await _cartService.CreateCart(cartProduct));
        }
    }
}
