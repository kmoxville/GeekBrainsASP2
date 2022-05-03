namespace PersonsWebApp.DAL.Validation
{
    [Serializable]
    public class ValidationException : Exception
    {
        public ValidationException(IOperationResult operationResult) : base() 
        {
            Result = operationResult;
        }

        public IOperationResult Result { get; set; }
    }
}
