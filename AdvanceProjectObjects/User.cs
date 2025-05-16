using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdvancedProjectObjects
{
    public partial class User
    {
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Logs = new HashSet<Log>();
            Notifications = new HashSet<Notification>();
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
