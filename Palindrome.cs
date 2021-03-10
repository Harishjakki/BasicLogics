using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }
        private static bool IsPalindrome(int num)
        {
            int rev = 0;
            int copy = num;
            while (num > 0)
            {
                 rev =rev*10+ num % 10;
                num /= 10;
            }
            return rev == copy;
        }
    }
}
