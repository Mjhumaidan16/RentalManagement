using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class ReturnRecord
    {
        [Key]
        [Column("ReturnID")]
        public int ReturnId { get; set; }
        [Column("TransactionID")]
        public int TransactionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActualReturnDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ReturnCondition { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? LateReturnFees { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? AdditionalCharges { get; set; }

        [ForeignKey("TransactionId")]
        [InverseProperty("ReturnRecords")]
        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}
