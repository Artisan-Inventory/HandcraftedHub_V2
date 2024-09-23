using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class StatusChange
{
    [Key]
    [MaxLength(50)] public required string StatusChangeId { get; set; }
    [ForeignKey("Order")]
    [MaxLength(50)] public required string OrderId { get; set; }
    public DateTime ChangeTime { get; set; }
    [MaxLength(255)] public string? Status { get; set; }
    
    // Navigation properties
    public virtual Order? Order { get; set; }
}