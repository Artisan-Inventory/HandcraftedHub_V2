using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCraftedHub.BusinessObjects.Entities
{
    public class Promotion
    {
        [Key]
        [MaxLength(50)] 
        public required string PromotionId { get; set; }
        [ForeignKey("Category")]
        [MaxLength(50)]
        public required string CategoryId { get; set; }
        [MaxLength(255)]
        public required string PromotionName { get; set; }

        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        [MaxLength(255)]
        public string? Status { get; set; }
    }
}
