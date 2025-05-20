using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class RentalTransaction
    {
        public RentalTransaction()
        {
            Documents = new HashSet<Document>();
            Feedbacks = new HashSet<Feedback>();
            Payments = new HashSet<Payment>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("TransactionID")]
        public int TransactionId { get; set; }
        [Column("RequestID")]
        public int RequestId { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActualStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualReturnDate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal RentalFee { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Deposit { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string PaymentStatus { get; set; } = null!;
        public int? RentalPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateProcessed { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("RentalTransactions")]
        public virtual User Customer { get; set; } = null!;
        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalTransactions")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("RequestId")]
        [InverseProperty("RentalTransactions")]
        public virtual RentalRequest Request { get; set; } = null!;
        [InverseProperty("RentalTransaction")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("Transaction")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("Transaction")]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty("Transaction")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
