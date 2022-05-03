using FluentValidation;
using PersonsWebApp.Requests;

namespace PersonsWebApp.DAL.Validation.Requests.Person
{
    internal interface IInsertPersonValidator : IValidationService<InsertPersonRequest>
    {

    }

    internal sealed class InsertPersonValidator : ValidationService<InsertPersonRequest>, IInsertPersonValidator
    {
        public InsertPersonValidator()
        {
            RuleFor(x => x.Person.Id)
                .GreaterThan(0)
                .WithErrorCode("PE-103.1");

            RuleFor(x => x.Person.FirstName)
                .NotEmpty()
                .WithErrorCode("PE-103.2")
                .MaximumLength(100)
                .WithErrorCode("PE-103.3");

            RuleFor(x => x.Person.LastName)
                .NotEmpty()
                .WithErrorCode("PE-103.4")
                .MaximumLength(100)
                .WithErrorCode("PE-103.5");

            RuleFor(x => x.Person.Company)
                .NotEmpty()
                .WithErrorCode("PE-103.6")
                .MaximumLength(100)
                .WithErrorCode("PE-103.7");

            RuleFor(x => x.Person.Email)
                .EmailAddress()
                .WithErrorCode("PE-103.8");
        }
    }
}
