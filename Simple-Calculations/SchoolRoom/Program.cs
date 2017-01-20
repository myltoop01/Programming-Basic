using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine())*100;
            var h = double.Parse(Console.ReadLine())*100;
            var red = Math.Truncate(w / 120);

           
           
            var redB = Math.Truncate((h-100) / 70);
            Console.WriteLine((red * redB) - 3);



        }
    }
}
 