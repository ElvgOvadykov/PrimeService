using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService
{
    public class PrimeClass
    {
        public static bool isPrime(int value)
        {
            if (value == 1) // 1 - не простое число
                return false;
            // перебираем возможные делители от 2 до sqrt(n)
            for (int d = 2; d * d <= value; d++)
            {
                // если разделилось нацело, то составное
                if (value % d == 0)
                    return false;
            }
            // если нет нетривиальных делителей, то простое
            return true;
        }
    }
    
}
