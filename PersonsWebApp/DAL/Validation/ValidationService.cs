using FluentValidation;
using System.Linq;

namespace PersonsWebApp.DAL.Validation
{
    public interface IValidationService<TRequest>
        where TRequest : class
    {
        IOperationResult ValidateRequest(TRequest request);
    }

    public abstract class ValidationService<TRequest> : AbstractValidator<TRequest>, IValidationService<TRequest>
        where TRequest : class
    {
        public IOperationResult ValidateRequest(TRequest request)
        {
            var validationResult = Validate(request)!;

            if (validationResult.IsValid)
            {
                return new OperationResult(ArraySegment<IOperationFailure>.Empty);
            }

            var errorsQuery = validationResult.Errors.Select(error =>
            {
                return new OperationFailure()
                {
                    PropertyName = error.PropertyName,
                    Code = error.ErrorCode,
                    Description = error.ErrorMessage
                };
            });

            return new OperationResult(errorsQuery.ToArray());
        }
    }
}
