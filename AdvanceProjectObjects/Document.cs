using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdvanceProjectObjects
{
    public partial class Document
    {
        [Key]
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [Column("RentalTransactionID")]
        public int RentalTransactionId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FileName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string FileType { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string FilePath { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? UploadedAt { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }

        [ForeignKey("RentalTransactionId")]
        [InverseProperty("Documents")]
        public virtual RentalTransaction RentalTransaction { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Documents")]
        public virtual User? User { get; set; }
    }
}
