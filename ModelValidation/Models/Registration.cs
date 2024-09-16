using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    //Composite Validation with Custom Attribute
    public class Registration : IValidatableObject
    {
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Password must be matched")]
        public string ConfirmedPassword { get; set; }

      //  [Range(18, 120, ErrorMessage = "Age must be between 18 and 120")]
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Age < 18 && Age > 120)
                yield return new ValidationResult("Age must be between 18 and 120", new[] { nameof(Age) });
            if(string.IsNullOrEmpty(UserName))
                yield return new ValidationResult("user name is required", new[] {nameof(UserName)});

        }
    }
}
