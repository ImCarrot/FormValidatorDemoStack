namespace FormValidatorDemo.Model
{
    internal class ValidationError
    {
        public ValidationErrors ErrorType { get; set; }

        public string ErrorMessage { get; set; }
    }

    internal enum ValidationErrors
    {
        ID,
        Description,
        LocationLost,
        PersonName,
        ContactNo,
        AdminNo,
        DateLost
    }

}
