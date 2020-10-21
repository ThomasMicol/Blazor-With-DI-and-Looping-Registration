using Microsoft.Extensions.DependencyInjection;

namespace Blazor_With_DI_and_Looping_Registration.IoC.InstantiationFunctions
{
    interface IInstantiationFunction
    {
        void Register(IServiceCollection services);
    }
}
