using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Review
{
    [Key]
    [MaxLength(50)] 
    public required string ReviewId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Product")]
    public required string ProductId { get; set; }
    [MaxLength(50)]
    [ForeignKey("ApplicationUser")]
    public required Guid UserId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Reply")]
    public required string ReplyId { get; set; }
    [MaxLength(255)] public string? Content { get; set; }
    public int Rating { get; set; }
    public DateTime Date { get; set; }


    // Navigation properties
    public virtual Product? Product { get; set; }
    public virtual ApplicationUser? User { get; set; }
    public virtual Reply? Reply { get; set; }
}