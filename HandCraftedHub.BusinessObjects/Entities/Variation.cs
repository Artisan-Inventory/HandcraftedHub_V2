using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCraftedHub.BusinessObjects.Entities
{
    public class Variation
    {
        [Key]
        [MaxLength(50)]
        public required string VariationId { get; set; }

        [ForeignKey("Category")]
        [MaxLength(50)]
        public required string CategoryId { get; set; }
        [MaxLength(255)]
        public required string VariationName { get; set; }


        // Navigation properties
        public virtual Category? Category { get; set; }
        public virtual VariationOption? VariationOption { get; set; }
    }
}
