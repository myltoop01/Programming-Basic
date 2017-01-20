using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var magn = double.Parse(Console.ReadLine());
            var zumb = double.Parse(Console.ReadLine());
            var rose = double.Parse(Console.ReadLine());
            var kakt = double.Parse(Console.ReadLine());
            var priceP = double.Parse(Console.ReadLine());
            var moneyMagn = magn * 3.25;
            var moneyZumb = zumb * 4;
            var moneyrose = rose * 3.5;
            var moneykakt = kakt * 8;
            var allMoney = moneyMagn + moneyZumb + moneyrose+moneykakt;
            var allMoney1 = allMoney - (allMoney * 0.05);
            
                if (allMoney1 >= priceP)
                {
                    Console.WriteLine("She is left with {0} leva.", Math.Truncate(allMoney1 - priceP));
                }
               else
                {
                    Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling((priceP - allMoney1)));
               
            }
            
        }
    }
}
