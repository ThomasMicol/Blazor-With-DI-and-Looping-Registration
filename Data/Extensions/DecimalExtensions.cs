using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToCurrency(this decimal dec)
        {
            var stringDec = dec.ToString();
            if((dec % 1) == 0)
            {
                stringDec = $"{stringDec}.00";
            }

            return $"${stringDec}";
        }
    }
}
