using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedroHortifrutiMvc.Models;

namespace PedroHortifrutiMvc.Data
{
    public class PedroHortifrutiMvcContext : DbContext
    {
        public PedroHortifrutiMvcContext (DbContextOptions<PedroHortifrutiMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<CartProduct> CartProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<CartProduct>().HasKey(cartProduct => new { cartProduct.CartId, cartProduct.ProductId });

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product{Id = 1, Name = "Coco-da-Bahia", Price = 3.00},
                new Product{Id = 2, Name = "Abóbora", Price = 7.25},
                new Product{Id = 3, Name = "Ovos", Price = 9.50}
            });
        }
    }
}
