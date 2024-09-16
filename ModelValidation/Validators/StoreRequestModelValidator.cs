using FluentValidation;
using FluentValidation.Internal;
using ModelValidation.Models;
using System.Net;

namespace ModelValidation.Validators
{
    public class StoreRequestModelValidator : AbstractValidator<StoreRequestModel>
    {
        public StoreRequestModelValidator() 
        {
            RuleFor(s => s.StoreName)
                   .NotEmpty().WithMessage("Name is Required")
                   .Length(2, 100).WithMessage("Name length between 3 and 8");

            RuleFor(x => x.ContacNo)
                .Length(1, 10).WithMessage("Invalid Length of characters");

            RuleFor(x => x.Email)
          .EmailAddress().WithMessage("Invalid Email Address");

            RuleFor(x => x.RegistrationNo)
                .MaximumLength(10).WithMessage("Invalid Length of characters");

            RuleFor(x => x.categoryIds)
               .NotEmpty().WithMessage("Required Name");
        }
    }
}
