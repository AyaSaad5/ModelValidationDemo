using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    // Email and Phone Number Validation
    public class Customer
    {
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Invalid Phone Number")]
        public string Phone { get; set; }
    }
}
