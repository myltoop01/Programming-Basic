using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            if (km >= 100)
                Console.WriteLine(km * 0.06);
            else if (km >= 20 && km < 100)
                Console.WriteLine(km * 0.09);
            else if (dayNight == "day")
                Console.WriteLine((km * 0.79) + 0.7);
            else if (dayNight == "night") 
            Console.WriteLine((km * 0.90) + 0.7);

        }
    }
}
