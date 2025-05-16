using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectObjects
{
    public partial class RentalTransaction
    {
        public RentalTransaction()
        {
            Documents = new HashSet<Document>();
            Payments = new HashSet<Payment>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        public int TransactionId { get; set; }

        public int RequestId { get; set; }
        [ForeignKey("RequestId")]

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public int EquipmentId { get; set; }
        [ForeignKey("RequestId")]

        [Required]
        public DateTime ActualStartDate { get; set; }

        public DateTime? ActualReturnDate { get; set; }

        [Required]
        public decimal RentalFee { get; set; }

        [Required]
        public decimal Deposit { get; set; }

        [Required]
        public string PaymentStatus { get; set; } = null!;

        public virtual User Customer { get; set; } = null!;
        public virtual Equipment Equipment { get; set; } = null!;
        public virtual RentalRequest Request { get; set; } = null!;
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
