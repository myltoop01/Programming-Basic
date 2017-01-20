using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());
            
            var areaPlostadka = n * n;
            var areaPejka = m * o;
            var areaPlochki = w * l;
            var areaPokrivane = areaPlostadka - areaPejka;
            var neobhdPlochki = areaPokrivane / areaPlochki;
            var neobhvreme = (neobhdPlochki * 0.2);
            Console.WriteLine(neobhdPlochki);
            Console.WriteLine(neobhvreme);

        }
    }
}
