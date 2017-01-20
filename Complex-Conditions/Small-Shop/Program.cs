using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            if (town == "sofia")
               {
                if (produkt == "coffee")
                {
                    Console.WriteLine(quantity*0.5);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(0.8 * quantity);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(1.2 * quantity);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(1.60 * quantity);
                }
               }
            if (town == "plovdiv")
            {
                if (produkt == "coffee")
                    Console.WriteLine(0.4 * quantity);
                else if (produkt == "water")
                    Console.WriteLine(0.7 * quantity);
                else if (produkt == "beer")
                    Console.WriteLine(1.15 * quantity);
                else if (produkt == "sweets")
                    Console.WriteLine(1.30 * quantity);
                else if (produkt == "peanuts")
                    Console.WriteLine(1.50 * quantity);
            }
            if (town == "varna")
            { 
                if (produkt == "coffee")
                    Console.WriteLine(0.45 * quantity);
                else if (produkt == "water")
                    Console.WriteLine(0.7 * quantity);
                else if (produkt == "beer")
                    Console.WriteLine(1.1 * quantity);
                else if (produkt == "sweets")
                    Console.WriteLine(1.35 * quantity);
                else if (produkt == "peanuts")
                    Console.WriteLine(1.55 * quantity);
                }
        }
    }
}
