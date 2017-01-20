using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string move = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var p = 12.00;
            var n = 7.50;
            var d = 5.00;

            if (move == "premiere")
                Console.WriteLine("{0:f2},{1}", r * c * p, "лева");
          else  if (move == "normal")
                Console.WriteLine("{0:f2},{1}", r * c * n, "лева");
           else  if (move == "discount")
                Console.WriteLine("{0:f2},{1}", r * c * d, "лева");
        }
    }
}
