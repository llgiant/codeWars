using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app009_Number_of_trailing_zeros_of_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(100));
            Console.ReadLine();
        }

        public static int TrailingZeros(int number)
        {
            int result = 0;

            while (number / 5 > 0)
            {
                result += number / 5;
                number /= 5;
            }

            return result;
        }
    }


}

