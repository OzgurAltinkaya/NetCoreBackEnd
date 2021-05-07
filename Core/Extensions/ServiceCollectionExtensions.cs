using System;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{

    public static class ServiceCollectionExtensions
    {
        //this- neyi genişletmek istiyorsak kullanıyoruz. ve parametreler.Polymorphsm yapıyoruz.
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection); //Core katmanında da dahil olmak üzere ekleyeceğimiz enjeksiyonları, modulleri eklememizi sağlamak için.

        }
    }

}
