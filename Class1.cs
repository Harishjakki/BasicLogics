using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
  
        static void Main(string[] args)
        {
            int num = 568;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                Console.WriteLine(digit);
            }
        }
    }
}
