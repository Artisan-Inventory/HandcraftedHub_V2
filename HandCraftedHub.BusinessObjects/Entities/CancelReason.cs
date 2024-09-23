using System.ComponentModel.DataAnnotations;

namespace HandCraftedHub.BusinessObjects.Entities;

public class CancelReason
{
    [MaxLength(50)] public required string CancelReasonId { get; set; }
    [MaxLength(50)] public required string OrderId { get; set; }
    [MaxLength(255)] public string? Description { get; set; }

    public float RefundRate { get; set; }

    // Navigation properties
    public virtual Order? Order { get; set; }
}