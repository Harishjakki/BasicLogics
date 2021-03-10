using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Saparate
    {
        public static string  Digits1(int num)
        {
            string str = string.Empty;

            while (num > 0)
            {
                int digit = num % 10;
                str = str + digit + "\n";
                num /= 10;
            }
            return str;
        }


static void Main(string[] args)
        {
            Console.WriteLine(Digits1(363));
        }
    }
}
