using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            
                if ((x > 0 && x < 3 * h && y > 0 && y < h)|| (x > h && x < 2 * h && y > h && y < 4 * h) || (x >  h && x < 2 * h && y == h))
                {
                    Console.WriteLine("inside");
                }

                else if ((x >= 0 && x <= 3 * h && y >= 0 && y <= h) || (x >= h && x <= 2 * h && y >= h && y <= 4 * h))
                {
                    Console.WriteLine("border");
                }

                else Console.WriteLine("outside");
           
                
            
        }
    }
}
