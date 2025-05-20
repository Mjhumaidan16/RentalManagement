using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class Payment
    {
        [Key]
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column("TransactionID")]
        public int TransactionId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentMethod { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Status { get; set; } = null!;

        [ForeignKey("TransactionId")]
        [InverseProperty("Payments")]
        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}
