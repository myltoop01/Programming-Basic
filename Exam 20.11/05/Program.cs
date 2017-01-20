using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', ((3 * n - 2) / 2) - i),new string(' ', i+(3*n-(2+(2*((3 * n - 2) / 2) - i)))));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 3 - (n / 2) * 2));
            for (int i1 = 0; i1 < n*2; i1++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2),new string ('\\',n*3 - n/2 - n/2 - 2));
            }
            for (int i2 = 0; i2 < n/2; i2++)

            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', n / 2 - i2), new string('*', (3 * n) - 2 - 2*(n / 2 - i2)));
            }
        }
    }
}
