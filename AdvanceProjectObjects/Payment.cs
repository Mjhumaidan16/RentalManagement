using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectObjects
{
    public partial class Payment
    {

        [Key]
        public int PaymentId { get; set; }

        public int TransactionId { get; set; }
        [ForeignKey("TransactionId")]

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = null!;


        public DateTime? PaymentDate { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}
