using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            string sasion = Console.ReadLine();
            if (n<=100 && sasion == "summer")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", ((n/100)*30));
            }
            if (n <= 100 && sasion == "winter")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", ((n / 100) * 70));
            }
            if (n <= 1000 && n > 100 && sasion == "summer")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", ((n / 100) * 40));
            }
            if (n <= 1000 && n > 100 && sasion == "winter")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", ((n / 100) * 80));
            }
            if (n > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", ((n / 100) * 90));
            }

        } 
    }
}
