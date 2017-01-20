using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var blanks = n - 1 / 2;
            var stars = 1;
            if (n % 2 == 0) 
            {
                blanks = n - 2 / 2;
                 stars = 2;
            }
            Console.Write("{0}{1}{0}", new string('_',stars));
        }
    }
}
