using System.ComponentModel.DataAnnotations;
using HandCraftedHub.BusinessObjects.Utils;
using Microsoft.AspNetCore.Identity;

namespace HandCraftedHub.BusinessObjects.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [MaxLength(255)] public string? DisplayName { get; set; }
        [MaxLength(255)] public string? Bio { get; set; }
        [MaxLength(255)] public string? Fullname { get; set; }
        [MaxLength(255)] public string? Address { get; set; }
        [MaxLength(255)] public string? Status { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Password { get; set; } = string.Empty;
        public virtual UserInfo? UserInfo { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }

        public ApplicationUser()
        {
            CreatedTime = CoreHelper.SystemTimeNow;
            LastUpdatedTime = CreatedTime;
        }


        // Navigation properties
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<MediaUpload>? MediaUploads { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual Shop? Shop { get; set; }
        public virtual Cart? Cart { get; set; }
        public virtual Product? Product { get; set; }
    }
}