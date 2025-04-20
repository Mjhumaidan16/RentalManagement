using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectClasses.Models
{
    public partial class Feedback
    {

        [Key]
        public int FeedbackId { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public int EquipmentId { get; set; }
        [ForeignKey("EquipmentId")]

        [Required]
        public int Rating { get; set; }


        public string? Comment { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User Customer { get; set; } = null!;
        public virtual Equipment Equipment { get; set; } = null!;
    }
}
