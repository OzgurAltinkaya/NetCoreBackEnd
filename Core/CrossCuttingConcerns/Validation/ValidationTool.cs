using System;
using FluentValidation;
using Microsoft.Extensions.Options;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool
    //IValidator: ProductValidator ilgili methodun parametrelerini validate ettiğimiz class
    {
        public static void Validate(IValidator validator,object entity) 
        {
            var context = new ValidationContext<object>(entity);
            
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
