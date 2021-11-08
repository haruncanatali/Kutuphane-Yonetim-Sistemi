using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class ValidationTool
    {
        public static ValidationResult Validate(IValidator validator, object instance)
        {
            return validator.Validate(instance);
        }
    }
}
