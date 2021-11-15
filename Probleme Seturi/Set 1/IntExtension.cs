using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1
{
    public static class IntExtension
    {
        public static bool IsPalindrom(this int n)
        {
            return n == n.Reverse();
        }
        public static int Reverse(this int n)
        {
            int result = 0;
            int cifra;
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;

                result = result * 10 + cifra;
            }

            return result;
        }
    }
}
