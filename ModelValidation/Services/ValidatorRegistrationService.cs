using FluentValidation.AspNetCore;
using ModelValidation.Validators;

namespace ModelValidation.Services
{
    public static class ValidatorRegistrationService
    {
        public static IMvcBuilder AddFluentValidationValidators(this IMvcBuilder builder)
        {
            return builder.AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<StoreRequestModelValidator>();
            });
        }
    }
}
