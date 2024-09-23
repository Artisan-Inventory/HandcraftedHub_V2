using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Product
{
    [Key]
    [MaxLength(50)] public required string ProductId { get; set; }
    [MaxLength(255)] public string? ProductName { get; set; }
    [MaxLength(255)] public string? Description { get; set; }
    public float? Price { get; set; }
    public int? StockQuantity { get; set; }
    [MaxLength(255)]
    public string? Status { get; set; }
    public float? Rating { get; set; }
    public int? SoldCount { get; set; }
    public DateTime ModifiedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    [ForeignKey("Category")]
    [MaxLength(50)] public required string CategoryId { get; set; }
    [ForeignKey("Shop")]
    [MaxLength(50)]
    public required string ShopId { get; set; }
    [ForeignKey("ApplicationUser")]
    [MaxLength(50)]
    public required Guid ApplicationUserId { get; set; }



    // Navigation properties
    public virtual ApplicationUser? ApplicationUser { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Shop? Shop { get; set; }
    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }
    public virtual ICollection<MediaUpload>? MediaUploads { get; set; }
}