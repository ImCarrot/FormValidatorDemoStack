namespace FormValidatorDemo.ComponentModel
{
    internal interface IFormControl
    {
        bool IsError { get; set; }

        bool IsMandatory { get; set; }

        string HeaderName { get; set; }

        void ValidateData();
    }
}
