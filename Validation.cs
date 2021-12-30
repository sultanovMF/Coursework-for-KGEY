using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalCoursework
{
    internal class GroupValidation : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureInfo)
        {
            Console.WriteLine(value);
            return ValidationResult.ValidResult;
            //Course course = (value as BindingGroup).Items[0] as Course;
            //if (course.StartDate > course.EndDate)
            //{
            //    return new ValidationResult(false,
            //        "Start Date must be earlier than End Date.");
            //}
            //else
            //{
            //    return ValidationResult.ValidResult;
            //}
        }
    }
}
