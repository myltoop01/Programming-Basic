using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaLitlR = double.Parse(Console.ReadLine());
            var areaKitchen = double.Parse(Console.ReadLine());
            var areaPriceM = double.Parse(Console.ReadLine());
            var badroom = areaLitlR / 2;
            var room2 = areaLitlR + (areaLitlR*0.1);
            var room3 = room2 + (room2 * 0.1);
            var all = areaLitlR + areaKitchen + badroom + room2 + room3;
            var all1 = all + all * 0.05;
            Console.WriteLine("{0:f2}",all1*areaPriceM);

        }
    }
}
