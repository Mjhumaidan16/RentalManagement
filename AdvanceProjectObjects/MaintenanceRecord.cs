using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectClasses.Models
{
    public partial class MaintenanceRecord
    {

        [Key]
        public int MaintenanceId { get; set; }


        public int EquipmentId { get; set; }
        [ForeignKey("EquipmentId")]


        [Required]
        public DateTime MaintenanceDate { get; set; }


        public string Description { get; set; } = null!;

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public virtual Equipment Equipment { get; set; } = null!;
    }
}
