using System;
using System.Linq;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspec
    {
        private Type _validatorType;

        public ValidationAspect(Type validatorType)
        {
            //defensice coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)// validation, doğrulama olduğu için methodun başında ezdik(OnBefore)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//ProdcutValidator'ın instance(new'ledi)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];// Product Tipi
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//Add'in argumanlarını giz
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }

    }
}
