using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandCraftedHub.BusinessObjects.Entities;

public class MediaUpload
{
    [Key]

    [MaxLength(50)]
    public required string MediaUploadId { get; set; }
    [ForeignKey("ApplicationUser")]
    [MaxLength(50)] 
    public required Guid UserId { get; set; }
    [ForeignKey("Category")]
    [MaxLength(50)]
    public required string CategoryId { get; set; }
    [MaxLength(255)] public string? Url { get; set; }
    public Boolean IsMain { get; set; }
    
    // Navigation properties
    public virtual ApplicationUser? User { get; set; }
    public virtual Category? Category { get; set; }
}