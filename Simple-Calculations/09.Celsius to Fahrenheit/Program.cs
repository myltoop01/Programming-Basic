using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var tC = double.Parse(Console.ReadLine());
            var tF = (1.8 * tC) + 32;
             tF = Math.Round(tF, 2);
            Console.WriteLine(tF);


        }
    }
}
