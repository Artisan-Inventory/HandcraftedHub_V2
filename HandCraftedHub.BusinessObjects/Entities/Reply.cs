using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class Reply
{
    [Key]
    [MaxLength(50)] 
    public required string ReplyId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Review")]
    public required string ReviewId { get; set; }
    [MaxLength(50)]
    [ForeignKey("Shop")] 
    public required string ShopId { get; set; }
    [MaxLength(255)] public string? Content { get; set; }
    public DateTime Date { get; set; }
    
    // Navigation properties
    public virtual Review? Review { get; set; }
    public virtual Shop? Shop { get; set; }
}