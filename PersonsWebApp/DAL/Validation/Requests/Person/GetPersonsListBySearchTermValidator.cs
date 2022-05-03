using FluentValidation;
using PersonsWebApp.Requests;

namespace PersonsWebApp.DAL.Validation.Requests.Person
{
    internal interface IGetPersonsListBySearchTermValidator : IValidationService<GetPersonsListBySearchTermRequest>
    {

    }

    internal sealed class GetPersonsListBySearchTermValidator : ValidationService<GetPersonsListBySearchTermRequest>, IGetPersonsListBySearchTermValidator
    {
        public GetPersonsListBySearchTermValidator()
        {
            RuleFor(x => x.SearchTerm)
                .MinimumLength(3)
                .WithErrorCode("PE-100.1");

            RuleFor(x => x.SearchTerm)
                .MaximumLength(100)
                .WithErrorCode("PE-100.2");
        }
    }
}
