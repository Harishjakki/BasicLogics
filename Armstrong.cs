using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(153));
        }
        private static bool IsArmstrong(int num)
        {
            double sum = 0;
            double copy = Convert.ToDouble(num);
            string str = (num).ToString();
            double num1 = Convert.ToDouble(str.Length);
            while(num>0)
            {
                int digit = num % 10;
                sum = sum + Math.Pow(digit, num1);
                num /= 10;
            }
            return sum == copy;
        }
    }
}
