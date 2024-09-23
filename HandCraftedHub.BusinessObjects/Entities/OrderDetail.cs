using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class OrderDetail
{
    [Key]
    [MaxLength(50)] 
    public required string OrderDetailId { get; set; }
    [ForeignKey("Order")]
    [MaxLength(50)] 
    public required string OrderId { get; set; }
 
    [MaxLength(50)]
    [ForeignKey("Product")]
    public required string ProductId { get; set; }
    public int ProductQuantity { get; set; }
    public float ProductPrice { get; set; }


    // Navigation properties
    public virtual Order? Order { get; set; }
    public virtual Product? Product { get; set; }
    public virtual CancelReason? CancelReason { get; set; }
}