namespace ZeMERP.DTO.Shared
{
    public class ErrorViewModel
    {
        public string ValidatorKey { get; private set; }
        public string Message { get; private set; }

        public ErrorViewModel(string message, string validatorKey = "")
        {
            ValidatorKey = validatorKey;
            Message = message;
        }
    }
}
