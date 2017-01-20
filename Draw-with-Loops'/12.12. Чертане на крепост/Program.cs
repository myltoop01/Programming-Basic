using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12.Чертане_на_крепост
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = n / 2;
            var b = 2 * n - 2 * a - 4;
            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', a), new string('_', b));
            for (int i = 1; i < n-2; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', n*2 - 2));
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write("|{0}{1}{0}|",new string(' ',a+1),new string('_',b), new string(' ', a));
            
            Console.WriteLine();
            Console.Write(@"\{0}/{1}\{0}/", new string('_', a), new string(' ', b), new string('_', a));
        }
    }
          
}

