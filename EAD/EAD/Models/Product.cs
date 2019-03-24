using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EAD.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [MaxLength(70)]
        public string ProductName { get; set; }


        [Display(Name = "Product Details")]
        [Column(TypeName = "ntext")]
        [MaxLength]
        public string ProductDetails { get; set; }

        [Display(Name = "Price")]
        [Range(1, int.MaxValue, ErrorMessage = "Price should be greater than ${1}")]
        public double Price { get; set; }
    }
}
