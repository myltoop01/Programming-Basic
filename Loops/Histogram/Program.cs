﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                    if (num < 200) p1 ++;
          
                    if (num >= 200 && num < 400) p2 ++;
                    if (num >= 400 && num < 600) p3 ++;
                    if (num >= 600 && num < 800) p4 ++;
                    if (num >= 800) p5 ++;
             

            }

            Console.WriteLine((p1/n) *100 );
            Console.WriteLine((p2 * 100) / n);
            Console.WriteLine((p3 * 100) / n);
            Console.WriteLine((p4 * 100) / n);
            Console.WriteLine((p5 / n) *100);




        }
    }
}
