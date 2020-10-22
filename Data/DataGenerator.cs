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

            var investor1 = new Investor
            {
                Id = 1
                , Email = "testEmail1@gmail.com"
                , Income = 50000M
                , Name = "David Stokes"
                , Password = "davieDaMan123"
            };

            var investor2 = new Investor
            {
                Id = 2
                , Email = "newEmail@gmail.com"
                , Income = 70000M
                , Name = "Fiona Slight"
                , Password = "abc123"
            };

            var investor3 = new Investor
            {
                Id = 3
                , Email = "testingFun@aol.net"
                , Income = 250000M
                , Name = "Ashley Lane"
                , Password = "bigMoney321"
            };

            db.Investors.Add(investor1);
            db.Investors.Add(investor2);
            db.Investors.Add(investor3);

            db.SaveChangesAsync();

            DataGenerator.HasRun = true;
        }
    }
}
