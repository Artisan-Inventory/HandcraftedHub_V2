using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Cart
{
    [Key]
    [MaxLength(50)]
    public required string CartId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Product")]
    public required string ProductId { get; set; }
    [MaxLength(50)]
    [ForeignKey("ApplicationUser")]
    public required Guid UserId { get; set; }
    public int ProductQuantity { get; set; }
    
    
    // Navigation properties
    public virtual ApplicationUser? User { get; set; }
    prop
}