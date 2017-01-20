using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = double.Parse(Console.ReadLine());
            var seniors = double.Parse(Console.ReadLine());
            string race = Console.ReadLine().ToLower();
            var allMoney = 0.0;
            var allMoneyLast = 0.0;
            if (race == "trail")
            {
                allMoney = (juniors * 5.5) + (seniors * 7);
                allMoneyLast = allMoney - allMoney * 0.05;
                 {
                    Console.WriteLine("{0:f2}",allMoneyLast);
                 }
                
            }
            if (race == "cross-country")
            {
                if (juniors + seniors < 50)
                {
                    allMoney = (juniors * 8) + (seniors * 9.5);
                    allMoneyLast = allMoney - allMoney * 0.05;
                    {
                        Console.WriteLine("{0:f2}", allMoneyLast);
                    }

                }
                if (juniors + seniors >= 50)
                {
                    allMoney = (juniors * (8-8*0.25)) + (seniors * (9.5-9.5*0.25));
                    allMoneyLast = allMoney - allMoney * 0.05;
                    {
                        Console.WriteLine("{0:f2}", allMoneyLast);
                    }

                }

             }

            if (race == "downhill")
            {
                allMoney = (juniors * 12.25) + (seniors * 13.75);
                allMoneyLast = allMoney - allMoney * 0.05;
                {
                    Console.WriteLine("{0:f2}", allMoneyLast);
                }

            }
            if (race == "road")
            {
                allMoney = (juniors * 20) + (seniors * 21.50);
                allMoneyLast = allMoney - allMoney * 0.05;
                {
                    Console.WriteLine("{0:f2}", allMoneyLast);
                }
            }
        }
    }
}
