using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Subcategory")]
    public class SubCategory
    {
        [Required]
        [StringLength (50)]
        [Display(Name = "SubCategory Name")]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
    }
}
