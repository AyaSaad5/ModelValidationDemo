using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    // Basic Required and String Length Validation
    public class Product
    {
        [Required(ErrorMessage ="Product Name is Required")]
        [StringLength(100, ErrorMessage ="Product Name can't be exceed 100 characters")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(10,10000,ErrorMessage ="Price must be between 10 and 10000")]
        public decimal Price { get; set; }
    }
}
