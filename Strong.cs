using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Strong
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsStrong(145));
        }

        private static bool IsStrong(int num)
        {
            return num == Factors(num);
        }
        private static int Factors(int num)
        {
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                sum +=Fact(digit);
                num /= 10;
            }
            return sum;
        }

        private static int Fact(int digit)
        {
            int fact = 1;
            for (int i = 1; i <= digit; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
