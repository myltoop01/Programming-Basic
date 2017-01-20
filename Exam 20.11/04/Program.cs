using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var allkg = 0.0;
            var busKg = 0.0;
            var lkwkg = 0.0;
            var tren = 0.00;
            var priceaLLKG = 0.00;
            
            for (int i = 0; i < n; i++)
            {
                var kg = double.Parse(Console.ReadLine());
                allkg = allkg + kg;
                if (kg < 4) busKg = busKg + kg;
                if (kg > 3 && kg <= 11) lkwkg = lkwkg + kg;
                if (kg >= 12 )tren = tren + kg;


            }
            var price = ((busKg * 200) + (lkwkg * 175) + (tren * 120)) / allkg;
            Console.WriteLine("{0:f2}",price);
            Console.WriteLine("{0:f2}%", (busKg / allkg)*100);
            Console.WriteLine("{0:f2}%", (lkwkg / allkg) * 100);
            Console.WriteLine("{0:f2}%", (tren / allkg) * 100);
        }
    }
}
