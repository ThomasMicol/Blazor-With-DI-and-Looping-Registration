using Blazor_With_DI_and_Looping_Registration.IoC.InstantiationFunctions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Blazor_With_DI_and_Looping_Registration.IoC
{
    public static class DependencyInjectionRegistration
    {
        public static IServiceCollection Register(IServiceCollection services)
        {
            var type = typeof(IInstantiationFunction);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass)
                .ToList();

            foreach (var locType in types)
            {
                var obj = (IInstantiationFunction)Activator.CreateInstance(locType);
                obj.Register(services);
            }

            return services;
        }
    }
}
