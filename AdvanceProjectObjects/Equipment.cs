using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectClasses.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Feedbacks = new HashSet<Feedback>();
            MaintenanceRecords = new HashSet<MaintenanceRecord>();
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        public int EquipmentId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string? Description { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        [Required]
        public decimal RentalPrice { get; set; }

        [Required]
        public string AvailabilityStatus { get; set; } = null!;

        [Required]
        public string ConditionStatus { get; set; } = null!;


        public DateTime? CreatedAt { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
