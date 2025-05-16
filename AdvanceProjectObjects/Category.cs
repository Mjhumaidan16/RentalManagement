using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdvancedProjectObjects
{
    public partial class Category
    {
        public Category()
        {
            Equipment = new HashSet<Equipment>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
