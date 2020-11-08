using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data.Extensions
{
    public static class TransactionExtensions
    {
        public static IncomeTransaction ConvertToYearlyStandard(this IncomeTransaction transaction)
        {
            switch (transaction.Frequency)
            {
                case TransactionFrequency.Weekly:
                    return new IncomeTransaction
                    {
                        Id = transaction.Id,
                        Investor = transaction.Investor,
                        Frequency = TransactionFrequency.Yearly,
                        TransactionAmount = transaction.TransactionAmount * 52
                    };
                case TransactionFrequency.Fortnightly:
                    return new IncomeTransaction
                    {
                        Id = transaction.Id,
                        Investor = transaction.Investor,
                        Frequency = TransactionFrequency.Yearly,
                        TransactionAmount = transaction.TransactionAmount * 26
                    };
                case TransactionFrequency.Monthly:
                    return new IncomeTransaction
                    {
                        Id = transaction.Id,
                        Investor = transaction.Investor,
                        Frequency = TransactionFrequency.Yearly,
                        TransactionAmount = transaction.TransactionAmount * 12
                    };
                case TransactionFrequency.Yearly:
                    return transaction;
                default:
                    throw new NotImplementedException();
            }
        }

        public static ExpenseTransaction ConvertToYearlyStandard(this ExpenseTransaction transaction)
        {
            switch (transaction.Frequency)
            {
                case TransactionFrequency.Weekly:
                    return new ExpenseTransaction
                    {
                        Id = transaction.Id,
                        Investor = transaction.Investor,
                        Frequency = TransactionFrequency.Yearly,
                        TransactionAmount = transaction.TransactionAmount * 52
                    };
                case TransactionFrequency.Fortnightly:
                    return new ExpenseTransaction
                    {
                        Id = transaction.Id,
                        Investor = transaction.Investor,
                        Frequency = TransactionFrequency.Yearly,
                        TransactionAmount = transaction.TransactionAmount * 26
                    };
                case TransactionFrequency.Monthly:
                    return new ExpenseTransaction
                    {
                        Id = transaction.Id,
                        Investor = transaction.Investor,
                        Frequency = TransactionFrequency.Yearly,
                        TransactionAmount = transaction.TransactionAmount * 12
                    };
                case TransactionFrequency.Yearly:
                    return transaction;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
