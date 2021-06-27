using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace Reverse
{
    class Solution
    {
        public static int Reverse(int x)
        {
            long res = 0;

            while (x != 0)
            {
                res = (x % 10) + res * 10;
                x /= 10;
            }

            if (res > Int32.MaxValue || res < Int32.MinValue)
                res = 0;

            return (int)res;
        }

        static void Main(string[] args)
        {
            int a = 321;            
            
            int res = Reverse(a);
            Console.WriteLine(res);
        }
    }
}
