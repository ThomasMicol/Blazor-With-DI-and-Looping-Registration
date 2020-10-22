using Blazor_With_DI_and_Looping_Registration.Data.Login;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.IoC.InstantiationFunctions
{
    public class LoginServiceRegistration : IInstantiationFunction
    {
        public void Register(IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
        }
    }
}
