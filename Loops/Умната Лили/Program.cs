using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var priceGame = int.Parse(Console.ReadLine());
            var maney = 0;
            var game = 0;
            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0) maney += (10+(10*((i-1)/2)));
                else game += 1; 

            }
            var maneyFromGame = priceGame * game;
             
            var allCash = maneyFromGame + (maney - Math.Round(age / 2));
            var diff = allCash - price;
            if (allCash > price)
                Console.WriteLine("Yes! {0:f2}", diff);
            else Console.WriteLine("No! {0:f2}", Math.Abs(diff));
        }
    }
}
