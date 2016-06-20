using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50), MinLength(5)] 
        public string Name { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(200), MinLength(5)] 
        public string Description { get; set; }

        [Display(Name = "Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Expiration { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "This field is required")]
        [DataType("decimal(12 ,2")]
        public double Price { get; set; }

    }
}
