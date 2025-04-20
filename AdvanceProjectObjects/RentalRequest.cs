using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectClasses.Models
{
    public partial class RentalRequest
    {
        public RentalRequest()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        public int RequestId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]


        public int EquipmentId { get; set; }
        [ForeignKey("EquipmentId")]


        [Required]
        public DateTime RentalStartDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        public decimal TotalCost { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public virtual User Customer { get; set; } = null!;
        public virtual Equipment Equipment { get; set; } = null!;
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
