using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class MaintenanceRecord
    {
        [Key]
        [Column("MaintenanceID")]
        public int MaintenanceId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime MaintenanceDate { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cost { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Status { get; set; } = null!;

        [ForeignKey("EquipmentId")]
        [InverseProperty("MaintenanceRecords")]
        public virtual Equipment Equipment { get; set; } = null!;
    }
}
