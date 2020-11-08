using Blazor_With_DI_and_Looping_Registration.Data.Dashboard.Models;
using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using Blazor_With_DI_and_Looping_Registration.Data.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data.Dashboard
{
    public class DashboardService : IDashboardService
    {
        public FinanceDbContext DbContext { get; }
        public ILoginService LoginService { get; }

        public DashboardService(FinanceDbContext dbContext
            , ILoginService loginService)
        {
            DbContext = dbContext;
            LoginService = loginService;
        }

        public void AddExpense(PaymentForm formData)
        {
            var expenseData = new ExpenseTransaction
            {
                Id = Guid.NewGuid(),
                Frequency = formData.Frequency,
                Investor = LoginService.Investor,
                TransactionAmount = formData.Amount,
                TransactionType = TransactionType.Expense
            };
            DbContext.Add<ExpenseTransaction>(expenseData);
            DbContext.SaveChanges();
        }

        public void AddIncome(PaymentForm formData)
        {
            var incomeData = new IncomeTransaction
            {
                Id = Guid.NewGuid(),
                Frequency = formData.Frequency,
                Investor = LoginService.Investor,
                TransactionAmount = formData.Amount,
                TransactionType = TransactionType.Income
            };
            DbContext.Add<IncomeTransaction>(incomeData);
            DbContext.SaveChanges();
        }
    }
}
