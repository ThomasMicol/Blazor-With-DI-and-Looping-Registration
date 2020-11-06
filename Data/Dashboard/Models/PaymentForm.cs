using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blazor_With_DI_and_Looping_Registration.Data.Dashboard.Models
{
    public class PaymentForm
    {
        public decimal Amount { get; set; }
        public TransactionFrequency Frequency { get; set; }
    }
}
