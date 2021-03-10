using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SumFact
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumFactors(12));
        }

        private static int SumFactors(int v)
        {
            int sum = 0;
            for (int i = 1; i <=v; i++)
            {
                if(v%i==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
