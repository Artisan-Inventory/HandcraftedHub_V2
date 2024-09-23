using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Order
{
    [Key]
    [MaxLength(50)]
    public required string OrderId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Payment")]
    public required string PaymentId { get; set; }
    [MaxLength(50)]
    [ForeignKey("ApplicationUser")]
    public required Guid UserId { get; set; }
    [MaxLength(50)]
    [ForeignKey("CancelReason")]
    public required string CancelReasonId { get; set; }
    public DateTime OrderDate { get; set; }
    [MaxLength(50)] public string? CurrentStatus { get; set; }
    public float TotalPrice { get; set; }
    [MaxLength(255)]
    public string? Address { get; set; }
    [MaxLength(255)]
    public string? CustomerName { get; set; }
    [Phone]
    [MaxLength(20)]
    public string? CustomerPhone { get; set; }
    [EmailAddress]
    [MaxLength(255)]
    public string? Note { get; set; }


    // Navigation properties
    public virtual CancelReason? CancelReason { get; set; }
    public virtual Account? Account { get; set; }
    public virtual Payment? Payment { get; set; }
    public virtual ApplicationUser? User { get; set; }
    public virtual ICollection<StatusChange>? StatusChanges { get; set; }
    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
}