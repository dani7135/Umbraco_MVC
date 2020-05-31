using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Umbraco_MVC.Services
{
    public class AgeServices : ValidationAttribute
    {//Her skal validationen af alder ligge
     //    public class DateMinimumAgeAttribute : ValidationAttribute
        public int MinAge {get;}
        public AgeServices(int minAge)
        {
            MinAge = minAge;
            ErrorMessage = "{0} must be someone at least {1} years of age";

        }
        public override bool IsValid(object value)
        {
            DateTime date;
            if ((value != null && DateTime.TryParse(value.ToString(), out date)))
            {
                return date.AddYears(MinAge) < DateTime.Now;
            }

            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, MinAge);
        }

   

    }
}
