using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data
{

    public static class DataGenerator
    {
        public static bool HasRun { get; set; }

        public static void Init(FinanceDbContext db)
        {
            if (HasRun)
            {
                return;
            }

            var trans1 = new IncomeTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 50000M,
                Frequency = TransactionFrequency.Yearly
            };
            var trans2 = new ExpenseTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 100M,
                Frequency = TransactionFrequency.Weekly
            };
            var trans3 = new IncomeTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 80000M,
                Frequency = TransactionFrequency.Yearly
            };
            var trans4 = new ExpenseTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 300M,
                Frequency = TransactionFrequency.Weekly
            };
            var trans5 = new IncomeTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 250000M,
                Frequency = TransactionFrequency.Yearly
            };
            var trans6 = new ExpenseTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 200M,
                Frequency = TransactionFrequency.Weekly
            };
            var trans7 = new IncomeTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 201M,
                Frequency = TransactionFrequency.Weekly
            }; 
            var trans8 = new IncomeTransaction
            {
                Id = Guid.NewGuid(),
                TransactionAmount = 210M,
                Frequency = TransactionFrequency.Weekly
            };

            var investor1 = new Investor
            {
                Id = Guid.NewGuid(),
                Email = "testEmail1@gmail.com"
                ,
                Income = new List<IncomeTransaction>()
                {
                    trans1,
                    trans7
                }
                , Expenses = new List<ExpenseTransaction>()
                {
                    trans2
                }
                , Name = "David Stokes"
                , Password = "davieDaMan123"
            };

            var investor2 = new Investor
            {
                Id = Guid.NewGuid(),
                Email = "newEmail@gmail.com"
                ,
                Income = new List<IncomeTransaction>()
                {
                    trans3
                }
                ,
                Expenses = new List<ExpenseTransaction>()
                {
                    trans4
                }
                ,
                Name = "Fiona Slight"
                ,
                Password = "abc123"
            };

            var investor3 = new Investor
            {
                Id = Guid.NewGuid(),
                Email = "testingFun@aol.net"
                ,
                Income = new List<IncomeTransaction>()
                {
                    trans5
                }
                ,
                Expenses = new List<ExpenseTransaction>()
                {
                    trans6
                }
                ,
                Name = "Ashley Lane"
                ,
                Password = "bigMoney321"
            };

            //db.Incomes.Add(trans1);
            //db.Expenses.Add(trans2);
            //db.Incomes.Add(trans3);
            //db.Expenses.Add(trans4);
            //db.Incomes.Add(trans5);
            //db.Expenses.Add(trans6);
            //db.Incomes.Add(trans7);
            //db.Incomes.Add(trans8);

            db.Investors.Add(investor1);
            db.Investors.Add(investor2);
            db.Investors.Add(investor3);

            db.SaveChangesAsync();

            DataGenerator.HasRun = true;
        }
    }
}