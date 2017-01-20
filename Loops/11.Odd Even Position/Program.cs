using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var evenSum = 0.0;
            var evenMin = 10000000000.0;
            var evenMax = -10000000000.0;
            var oddSum = 0.0;
            var oddMin = 10000000000.0;
            var oddMax = -10000000000.0;

            for (int i = 0; i < n; i++)

            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;

                    if (num > oddMax)
                        oddMax = num;
                    if (num < oddMin)
                        oddMin = num;
                }
              else  if (i % 2 != 0)
                {
                    evenSum += num;

                    if (num > evenMax)
                        evenMax = num;
                    if (num < evenMin)
                        evenMin = num;
                }

            }

            Console.WriteLine("OddSum="+ oddSum);
            if (oddMin < 10000000000.0)
            {
                Console.WriteLine("OddMin=" + oddMin);
            }
            else Console.WriteLine("OddMin=No" );
            if (oddMax > -10000000000.0)
            {
                Console.WriteLine("OddMax=" + oddMax);
            }
            else Console.WriteLine("OddMax=No");

            Console.WriteLine("EvenSum=" + evenSum);
            if (evenMin < 10000000000.0)
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }
            else
                Console.WriteLine("EvenMin=No" );
            if (evenMax > -10000000000.0)
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
            else Console.WriteLine("EvenMax=No");
        }
    }
}
