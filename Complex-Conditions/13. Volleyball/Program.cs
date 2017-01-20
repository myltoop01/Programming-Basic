using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yahr = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            
            double sofiaGame = ((48 - h) * 0.75);
            double sofiaPraznikGame = (p * 0.66666667);
           

            if (yahr == "normal")
            {
                Console.WriteLine(Math.Truncate(sofiaGame + h + sofiaPraznikGame));
            }
            double leap = ((sofiaGame + h + sofiaPraznikGame) * 0.15);
            if (yahr == "leap")
                Console.WriteLine(Math.Truncate((sofiaGame + h + sofiaPraznikGame)+leap));


        }
    }
}
