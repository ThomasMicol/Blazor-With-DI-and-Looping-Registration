using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data
{
    public class InvestorService
    {
        public InvestorService(FinanceDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public FinanceDbContext DbContext { get; }

        public Task<Investor> GetInvestor(Guid investorId)
        {
            return Task.FromResult(DbContext.Investors.Where(i => i.Id == investorId).FirstOrDefault());
        }

        public void CreateInvestor(Investor investor)
        {
            if (DbContext.Investors.Contains(investor))
            {
                return;
            }
            DbContext.Investors.Add(investor);
            DbContext.SaveChanges();
        }
    }
}
