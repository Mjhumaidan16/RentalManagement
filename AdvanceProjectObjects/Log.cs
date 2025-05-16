using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectObjects
{
    public partial class Log
    {

        [Key]
        public int LogId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]


        [Required]
        public string Action { get; set; } = null!;
        public DateTime? Timestamp { get; set; }

        [Required]
        public string Source { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
