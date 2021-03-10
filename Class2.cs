using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BasicOPer(234));
        }
        public static string  BasicOPer(int num)
        {
            int rev = 0;
            string gre = string.Empty;

            while (num > 0)
            {
                int digit = num % 10;
                rev = rev *10 + digit;
                num = num / 10;

            }
          
            while (rev > 0)
            {
                int digit = rev % 10;
                rev = rev / 10;
                gre = gre + digit + ",";
            }
            return gre.Substring(0,gre.Length-1)+".";
             
        }
    }
}
