using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MaxDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxDigitOfNum(654));
        }

        private static int MaxDigitOfNum(int v)
        {
            int max = v % 10;
            while(v>0)
            {
                int digit = v % 10;
                if(max<digit)
                {
                    max = digit;
                }
                v /= 10;
            }
            return max;
        }
    }
}
