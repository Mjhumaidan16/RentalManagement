using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class RentalRequest
    {
        public RentalRequest()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("RequestID")]
        public int RequestId { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RentalStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalCost { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DateRequested { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("RentalRequests")]
        public virtual User Customer { get; set; } = null!;
        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalRequests")]
        public virtual Equipment Equipment { get; set; } = null!;
        [InverseProperty("Request")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
