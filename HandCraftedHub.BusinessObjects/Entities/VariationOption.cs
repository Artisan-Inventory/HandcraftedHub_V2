using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCraftedHub.BusinessObjects.Entities
{
    public class VariationOption
    {
        [Key]
        [MaxLength(50)]
        public required string VariationOptionId { get; set; }

        [MaxLength(50)]
        [ForeignKey("Variation")]
        public required string VariationId { get; set; }

        [MaxLength(255)]
        public string? Value { get; set; }
    }
}
