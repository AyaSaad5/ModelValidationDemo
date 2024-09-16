using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    //Date Validation
    public class Appointment
    {
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Date must be in Future")]
        public DateTime AppointmentDate { get; set; }
    }
    //custom validation for future date
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateTime)
                return dateTime > DateTime.Now;
            return false;
        }
    }
}
