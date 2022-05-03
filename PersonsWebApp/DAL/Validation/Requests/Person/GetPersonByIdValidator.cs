using FluentValidation;
using PersonsWebApp.Requests;

namespace PersonsWebApp.DAL.Validation.Requests.Person
{
    internal interface IGetPersonByIdValidator : IValidationService<GetPersonByIdRequest>
    {

    }

    internal sealed class GetPersonByIdValidator : ValidationService<GetPersonByIdRequest>, IGetPersonByIdValidator
    {
        public GetPersonByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("PE-102.1");
        }
    }
}
