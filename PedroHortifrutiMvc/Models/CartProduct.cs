using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedroHortifrutiMvc.Models
{
    public class CartProduct
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
        public int Quantity { get; set; }

        
    }
}
