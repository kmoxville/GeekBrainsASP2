using FluentValidation;
using PersonsWebApp.Requests;

namespace PersonsWebApp.DAL.Validation.Requests.Person
{
    internal interface IDeletePersonByIdValidator : IValidationService<DeletePersonByIdRequest>
    {

    }

    internal sealed class DeletePersonByIdValidator : ValidationService<DeletePersonByIdRequest>, IDeletePersonByIdValidator
    {
        public DeletePersonByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("PE-101.1");
        }
    }
}