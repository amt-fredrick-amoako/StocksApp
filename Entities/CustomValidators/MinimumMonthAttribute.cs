using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.CustomValidators
{
    public class MinimumMonthAttribute : ValidationAttribute
    {
        //sets default year for property
        public int MinimumYear { get; set; } = 2000;
        public string DefaultErrorMessage { get; set; } = "Year should be no later than {0}";
        //parameterless constructor
        public MinimumMonthAttribute()
        {

        }
        //parameterized constructor to set the model property
        public MinimumMonthAttribute(int minimumYear)
        {
            MinimumYear = minimumYear;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //convert model value or property object to dateTime by explicit conversion
                DateTime date = (DateTime)value;
                if (date.Year <= MinimumYear)
                {
                    //pass in error message property of parent class to validation result constructor
                    //passes default error message if error message is not set by developer
                    //passes minimum year as index attribute to be referenced by the index property
                    return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, MinimumYear));
                }
                else
                {
                    return ValidationResult.Success;
                }

            }

            return null;
        }
    }
}
