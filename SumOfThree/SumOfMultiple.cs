using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    public class SumOfMultiple
    {
        public static int Find(int limit)
        {
            int sum = 0;
            int i = 0;

            do
            {
                i += 5;

                if (IsMultipleOfThree(i)) { sum += i; }
            }
            while (i < limit);

            return sum;
        }

        private static bool IsMultipleOfThree(int number) => SumOfDigits(number) == 3;
        
        private static int SumOfDigits(int number)
        {
            if(number == 0) { return 0; } // Avoid division by zero without resorting to exceptions

            int sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;
            }
            while (number > 0);

            return sum;
        }
    }
}
