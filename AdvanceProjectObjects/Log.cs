using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class Log
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(75)]
        [Unicode(false)]
        public string Action { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Source { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? Details { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Logs")]
        public virtual User User { get; set; } = null!;
    }
}
