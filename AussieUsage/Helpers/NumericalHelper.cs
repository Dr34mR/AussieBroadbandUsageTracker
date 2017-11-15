using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AussieUsage.Helpers
{
    internal static class NumericalHelper
    {
        internal static string Ordinal(int number)
        {
            string suffix;
            var ones = number % 10;
            var tens = (int)Math.Floor(number / 10M) % 10;

            if (tens == 1) { suffix = "th"; }
            else
            {
                switch (ones)
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;
                }
            }
            return $"{number} {suffix}";
        }
    }
}
