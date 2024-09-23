using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HandCraftedHub.BusinessObjects.Entities
{
    public class CartItem
    {
        [Key]
        [MaxLength(50)]
        public required string CartItemId { get; set; }
        [MaxLength(50)]
        [ForeignKey("Product")]
        public required string ProductId { get; set; }
        [MaxLength(50)]
        [ForeignKey("Cart")]
        public required string CartId { get; set; }

        public int ProductQuantity { get; set; }

        // Navigation properties
        public virtual Product? Product { get; set; }
        public virtual Cart? Cart { get; set; }

    }
}
