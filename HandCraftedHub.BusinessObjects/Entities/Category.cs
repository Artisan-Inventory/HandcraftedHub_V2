using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Category
{
    [Key]
    [MaxLength(50)] public required string CategoryId { get; set; }
    [MaxLength(255)] public string? CategoryName { get; set; }
    [MaxLength(255)] public string? Description { get; set; }


    // Navigation properties
    public virtual ICollection<Product>? Products { get; set; } = new List<Product>();
    public virtual ICollection<Variation>? Variations { get; set; } = new List<Variation>();
    public virtual ICollection<Promotion>? Promotions { get; set; } = new List<Promotion>();
}