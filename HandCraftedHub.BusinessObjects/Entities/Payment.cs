using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Payment
{
    [Key]
    [MaxLength(50)] 
    public required string PaymentId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Order")]
    public required string OrderId { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public float TotalAmount { get; set; }
    
    
    
    // Navigation properties
    public virtual Order? Order { get; set; }
    public virtual ICollection<PaymentDetail>? PaymentDetails { get; set; }
}