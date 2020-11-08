using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data.Dashboard
{
    interface IDashboardService
    {
        void AddIncome(Blazor_With_DI_and_Looping_Registration.Data.Dashboard.Models.PaymentForm formData);
        void AddExpense(Blazor_With_DI_and_Looping_Registration.Data.Dashboard.Models.PaymentForm formData);
    }
}
