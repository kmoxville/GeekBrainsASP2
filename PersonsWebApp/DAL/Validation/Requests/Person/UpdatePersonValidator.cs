using FluentValidation;
using PersonsWebApp.Requests;

namespace PersonsWebApp.DAL.Validation.Requests.Person
{
    internal interface IUpdatePersonValidator : IValidationService<UpdatePersonRequest>
    {

    }

    internal sealed class UpdatePersonValidator : ValidationService<UpdatePersonRequest>, IUpdatePersonValidator
    {
        public UpdatePersonValidator()
        {
            RuleFor(x => x.Person.Id)
                .GreaterThan(0)
                .WithErrorCode("PE-103.1");

            RuleFor(x => x.Person.FirstName)
                .NotEmpty()
                .MaximumLength(100)
                .WithErrorCode("PE-103.2");

            RuleFor(x => x.Person.LastName)
                .NotEmpty()
                .MaximumLength(100)
                .WithErrorCode("PE-103.3");

            RuleFor(x => x.Person.Company)
                .NotEmpty()
                .MaximumLength(100)
                .WithErrorCode("PE-103.4");

            RuleFor(x => x.Person.Email)
                .EmailAddress()
                .WithErrorCode("PE-103.5");
        }
    }
}
