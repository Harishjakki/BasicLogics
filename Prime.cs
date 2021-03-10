using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(7));
        }
        private static bool IsPrime(int v)
        {
            int count = 0;
            for (int i = 1; i <v; i++)
            {
                if(v%i==0)
                {
                    count++;
                }
            }
            return count == 1;
        }
    }
}
