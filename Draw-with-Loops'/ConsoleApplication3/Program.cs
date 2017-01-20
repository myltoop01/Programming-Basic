using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            for (int i = 0; i < n; i++)
            {
                var numer = double.Parse(Console.ReadLine());
                if (numer % 2 == 0) p1++;
                if (numer % 3 == 0) p2++;
                if (numer % 4 == 0) p3++;
            }
            Console.WriteLine("{0:f2}%",p1 / n * 100);
            Console.WriteLine("{0:f2}%",p2 / n * 100);
            Console.WriteLine("{0:f2}%",p3 / n * 100);
        }
    }
}
