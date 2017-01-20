using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = (((2 * n - 1) - 2) / 2);
            Console.WriteLine(new string('*',stars) + @"\ /"+ new string('*', stars));
            for (int i = 0; i <(( 2 * (n - 2) + 1)-3)/2/2; i++)
            {
                Console.WriteLine(new string('-', stars) + @"\ /" + new string('-', stars));
                Console.WriteLine(new string('*', stars) + @"\ /" + new string('*', stars));
                
            }
            Console.WriteLine(new string(' ', stars + 1) + "@");
            for (int i = 0; i < ((2 * (n - 2) + 1) - 3) / 2 / 2; i++)
            {
                Console.WriteLine(new string('*', stars) + @"/ \" + new string('*', stars));
                Console.WriteLine(new string('-', stars) + @"/ \" + new string('-', stars));
                

            }
            Console.WriteLine(new string('*', stars) + @"/ \" + new string('*', stars));
        }
    }
}
