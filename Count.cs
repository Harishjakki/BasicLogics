using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Count
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Countfact(12));
        }
        private static int Countfact(int num)
        {
            int count = 0;
            while(num>0)
            {
                int digit = num % 10;
                count++;
                num /= 10;
            }
            return count;
        }
    }
}
