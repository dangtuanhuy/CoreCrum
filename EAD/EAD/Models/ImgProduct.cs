using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EAD.Models
{
    public class ImgProduct
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "IMG")]
        public int ImgId { get; set; }

        [Display(Name = "Img Products")]
        public string ImgProducts { get; set; }

        [Required]
        [Display(Name = "Sort")]
        [Column(TypeName = "tinyint")]
        public byte SortImg { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
