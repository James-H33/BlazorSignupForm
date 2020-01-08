using System.ComponentModel.DataAnnotations;

namespace BlazorSignupForm.Utilities.Validators
{
    public class ZipCodeValidator: ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return new ValidationResult("Validation message to user.",
                new[] { validationContext.MemberName });
        }
    }
}