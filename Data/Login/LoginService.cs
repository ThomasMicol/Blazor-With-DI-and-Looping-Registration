using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data.Login
{
    public class LoginService : ILoginService
    {
        public Investor Investor { get; set; }

        public LoginService(FinanceDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public FinanceDbContext DbContext { get; }


        
        public Investor Login(string email, string password)
        {
            var investor = DbContext.Investors.Where(i => i.Email == email).FirstOrDefault();

            if (investor == default)
            {
                return null;
            }
            else
            {
                // this is not a demo for security. plain text passwords are bad
                if (investor.Password == password)
                {
                    Investor = investor;
                    return investor;
                }
                else
                {
                    return null;
                }
            }
            
         }
    }
}
