using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = double.Parse(Console.ReadLine());
            var bonusPoint = 0.0;
            var bonusPointA = 0.0;
            var bonusPointB = 0.0;
            if (point > 1000)
            {
                bonusPoint = point * 0.10;
            }

            else if (point > 100 && point <= 1000)
            {
                bonusPoint = point * 0.20;
            }
            else if (point <= 100)
            {
                bonusPoint = 5;
            }
           if (point % 2 == 0)
            {
                bonusPointA = +1;
           }
            else if (point % 10 == 5)
           {
               bonusPointB = +2;
           }              
            Console.WriteLine("Bonus points :" + (bonusPoint + bonusPointA + bonusPointB));
            Console.WriteLine("Total points :" + (point + bonusPoint+bonusPointA+bonusPointB));

        }
    }
}
