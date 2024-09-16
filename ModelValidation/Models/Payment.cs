using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    //Credit Card and URL Validation
    public class Payment
    {
        [CreditCard(ErrorMessage = "Invalid Credit Card Number")]
        public string CreditCardNumber { get; set; }

        [Url(ErrorMessage = "Invalid Url")]
        public string Website { get; set; }
    }
}
