using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PedroHortifrutiMvc.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}
