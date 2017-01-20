using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var uSD = double.Parse(Console.ReadLine());
            double bGN = uSD * 1.79549;
            bGN = Math.Round(bGN, 2);
            Console.WriteLine(bGN + " BGN");



        }
    }
}
