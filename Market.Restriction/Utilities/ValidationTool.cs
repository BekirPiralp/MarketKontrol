using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Restriction.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<TValidator>(object entity)
            where TValidator: IValidator, new()
        {
            TValidator validator = new TValidator();
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
                throw new ValidationException(result.Errors);
        }
        public static void Validate<TValidator>(List<object> entitys)
            where TValidator : IValidator, new()
        {
            for (int i = 0; i < entitys.Count; i++)
            {
                Validate<TValidator>(entitys[i]);
            }                      
        }
    }
}
