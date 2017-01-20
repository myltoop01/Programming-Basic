using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var minuteA = (minute + 15);

            if (hours == 23  && minuteA > 59 && (minuteA -60)< 10)

            {
                Console.WriteLine("0:0" + (minuteA - 60));
            }
            else if (hours == 23 && minute == 59)

            {
                Console.WriteLine("0:14");
            }
            else if (hours == 23 && minuteA > 59)

            {
                Console.WriteLine("0:" + (minuteA - 60));
            }
            else if (minute >= 45 && (minuteA - 60) < 10)
            {
                Console.WriteLine((hours + 1) + ":0" + (minuteA - 60));
            }
            else if (minute > 45)
            {
                Console.WriteLine((hours + 1) + ":" + (minuteA - 60));
            }

            else Console.WriteLine(hours + ":" + minuteA);



        }
    }
}
