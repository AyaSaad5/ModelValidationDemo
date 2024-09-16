using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    // Regular Expression Validation
    public class User
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.")]
        public string Password { get; set; }
    }
    public class CustomValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null && value.ToString().Contains("invalid"))
                return new ValidationResult("the value is invalid");
            return ValidationResult.Success;
        }
    }
}
