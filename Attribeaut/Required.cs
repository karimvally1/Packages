using Attribeaut.Constants;
using System.ComponentModel.DataAnnotations;

namespace Attribeaut
{
    public class Required : ValidationAttribute
    {
        public Required()
        {
            ErrorMessage = ValidatonError.REQUIRED;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            return !string.IsNullOrEmpty(strValue);
        }
    }
}
