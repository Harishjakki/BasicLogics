using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SepDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SeparateDigit(14354));
        }

        private static string SeparateDigit(int v)
        {
            string digit = string.Empty;
            while(v>0)
            {

                digit += v%10+ "\n";
                v /= 10;
            }
            return digit;
        }
    }
}
