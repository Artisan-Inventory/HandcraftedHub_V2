using System.ComponentModel.DataAnnotations;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Shop
{
    [MaxLength(50)] public required string ShopId { get; set; }
    [MaxLength(50)] public required Guid UserId { get; set; }
    [MaxLength(255)] public string? ShopName { get; set; }
    [MaxLength(255)] public string? Description { get; set; }
    public float Rating { get; set; }
    
    
    // Navigation properties
    public virtual ICollection<Product>? Products { get; set; } = new List<Product>();
    public virtual ApplicationUser? User { get; set; }
    public virtual ICollection<Reply>? Replies { get; set; } = new List<Reply>();
}