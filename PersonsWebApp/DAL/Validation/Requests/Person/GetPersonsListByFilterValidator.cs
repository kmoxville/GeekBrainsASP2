using FluentValidation;
using PersonsWebApp.Requests;

namespace PersonsWebApp.DAL.Validation.Requests.Person
{
    internal interface IGetPersonsListByFilterValidator : IValidationService<GetPersonsListByFilterRequest>
    {

    }

    internal sealed class GetPersonsListByFilterValidator : ValidationService<GetPersonsListByFilterRequest>, IGetPersonsListByFilterValidator
    {
        public GetPersonsListByFilterValidator()
        {
            RuleFor(x => x.Take)
                .LessThanOrEqualTo(20)
                .WithErrorCode("PE-105.1")
                .GreaterThan(0)
                .WithErrorCode("PE-105.2");

            RuleFor(x => x.Skip)
                .GreaterThanOrEqualTo(0)
                .WithErrorCode("PE-105.3");
        }
    }
}
