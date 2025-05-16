using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectObjects
{
    public partial class ReturnRecord
    {

        [Key]
        public int ReturnId { get; set; }

        public int TransactionId { get; set; }
        [ForeignKey("TransactionId")]

        [Required]
        public DateTime ActualReturnDate { get; set; }

        [Required]
        public string ReturnCondition { get; set; } = null!;


        public decimal? LateReturnFees { get; set; }
        public decimal? AdditionalCharges { get; set; }

        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}
