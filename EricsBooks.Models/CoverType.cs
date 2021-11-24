using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace EricsBooks.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cover Type List")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
