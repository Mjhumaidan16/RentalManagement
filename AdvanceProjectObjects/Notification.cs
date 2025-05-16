using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectObjects
{
    public partial class Notification
    {

        [Key]
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        [Required]
        public string MessageContent { get; set; } = null!;

        [Required]
        public string Type { get; set; } = null!;

        [Required]
        public string Status { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
