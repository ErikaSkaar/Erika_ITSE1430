using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public static class Validator
    {
        public static IEnumerable<ValidationResult> Validate ( IValidatableObject value )
        {
            var result = new List<ValidationResult>();

            var context = new ValidationContext(value);

            Validator.TryValidateObject(value, context, result, true);

            return result;
        }
    }
}
