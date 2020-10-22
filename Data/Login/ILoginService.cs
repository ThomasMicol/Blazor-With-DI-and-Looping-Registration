using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;

namespace Blazor_With_DI_and_Looping_Registration.Data.Login
{
    public interface ILoginService
    {
        Investor Investor { get; set; }
        Investor Login(string email, string password);
    }
}