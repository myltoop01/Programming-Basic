using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var outSide = n + 1;
            var inSide = n * 2;
            var inSide1 = inSide/2-1;
            var inSide2 = inSide / 2 - 1;
            var outSide3 = 1;
            Console.WriteLine(new string('.', outSide)+ new string('_', inSide+2)+ new string('.', outSide));
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', outSide-1)+"//"+ new string('_', inSide1+1) + new string('_', inSide2 + 1) + @"\\"+ new string('.', outSide-1));
                Console.WriteLine();
                outSide--;
                inSide1++;
                inSide2++;

            }
           
                Console.WriteLine(@"//" + new string('_', (4*n-5)/2) + "STOP!" + new string('_', (4 * n - 4) / 2) + @"\\");


          
           
            Console.WriteLine(@"\\" + new string('_', (4 * n)) + @"//");
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string('.', outSide3) + @"\\" + new string('_', inSide1 ) + new string('_', inSide2 ) + @"//" + new string('.', outSide3));
                Console.WriteLine();
                outSide3++;
                inSide1--;
                inSide2--;
            }
            }
    }
}
