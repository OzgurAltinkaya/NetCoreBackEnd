using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    //WebApı de ya da autosac te oluştuşturtuğumuz, Injectionları oluşturmaya yarıyor.
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
