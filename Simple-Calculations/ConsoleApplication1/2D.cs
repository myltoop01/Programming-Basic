using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете x1=");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Въведете x2=");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Въведете y1=");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Въведете y2=");
            double y2= double.Parse(Console.ReadLine());

            double a = Math.Max(x1, x2) - Math.Min(x1, x2);
            double b = Math.Max(y1, y2) - Math.Min(y1, y2);


            Console.WriteLine("Area=" + a * b);
            Console.WriteLine("Perimeter=" + ((a+b)*2));



        }
    }
}
