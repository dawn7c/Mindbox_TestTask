namespace Figures.Application.Validation
{
    public class ValidationResult
    {
        public string Message { get; set; }   
        public bool IsValid { get; set; }

        public ValidationResult(string message, bool isValid)
        {
            Message = message;
            IsValid = isValid;
        }
    }
}
