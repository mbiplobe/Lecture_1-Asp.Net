using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlossaryManagementSystem.Models
{
    public class Product {

        [Key]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }
  
        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Product Description is required")]
        public string ProductDescription { get; set; }

        [DisplayName("Product Categories")]
        [Required(ErrorMessage = "Product Categories is required")]
        public string productCategories { get; set; }

        [DisplayName("Number Of Product")]
        [Required(ErrorMessage = "Number Of Product is required")]
        public int NumberOfProduct { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product Price is required")]
        public double ProductPrice { get; set; }
    }
}