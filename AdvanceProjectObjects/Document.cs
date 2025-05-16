using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProjectObjects
{
    public partial class Document
    {

        [Key]
        public int DocumentId { get; set; }
        public int RentalTransactionId { get; set; }
        [ForeignKey("EmployeeId")]

        [Required]
        [MaxLength(50)]
        public string FileName { get; set; } = null!;

        [Required]
        public string FileType { get; set; } = null!;

        [Required]
        public string FilePath { get; set; } = null!;
        public DateTime? UploadedAt { get; set; }

        public virtual RentalTransaction RentalTransaction { get; set; } = null!;
    }
}
