using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [Column("FeedbackID")]
        public int FeedbackId { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        public int Rating { get; set; }
        [Column(TypeName = "text")]
        public string? Comment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("TransactionID")]
        public int? TransactionId { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Feedbacks")]
        public virtual User Customer { get; set; } = null!;
        [ForeignKey("EquipmentId")]
        [InverseProperty("Feedbacks")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("TransactionId")]
        [InverseProperty("Feedbacks")]
        public virtual RentalTransaction? Transaction { get; set; }
    }
}
