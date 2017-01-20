using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var hI = double.Parse(Console.ReadLine());
            var mI = double.Parse(Console.ReadLine());
            var hP = double.Parse(Console.ReadLine());
            var mP = double.Parse(Console.ReadLine());
            var hMI = ((hI * 60) + mI);
            var hMP = ((hP * 60) + mP);
            var diferense = hMP - hMI;
            if (diferense < -30)
                Console.WriteLine("Early");
            else if (diferense <= 0)
                Console.WriteLine("On time");
            else Console.WriteLine("Late");


            if (diferense != 0)
            {
                var hours = Math.Abs(diferense / 60);
           
                var mint = Math.Abs(diferense % 60);
                hours = Math.Truncate(hours);

                if (hours>0)
                {
                    if (mint < 10)
                        Console.Write(hours + ":0" + mint + " hours");
                    else
                        Console.Write(hours + ":" + mint + " hours");
                }
                else Console.Write(mint + " minutes");
                if (diferense < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");

            }
        }
       }
    }

