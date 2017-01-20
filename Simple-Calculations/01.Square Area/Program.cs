using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            var a = double.Parse(Console.ReadLine());
            double Area = a * a;
            Console.WriteLine(Area);


        }
    }
}
