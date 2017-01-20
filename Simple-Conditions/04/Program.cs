using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int first  = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third  = int.Parse(Console.ReadLine());
            int total = first + second + third;
            int minutes = 0;
            if (total < 60 && total > 10)
            {
                Console.WriteLine(minutes + ":" + total);
            }

            else if (total >= 60 && total < 120 && (total - 60) > 10)
              {
                Console.WriteLine("1:{0}", (total - 60));
              }
            else if (total >= 60 && total < 120 && (total - 60) < 10)
            {
                Console.WriteLine("1:0{0}", (total - 60));
            }
            
            else if (total >= 120 && total < 179 && (total - 120 )>=10)
            {
                Console.WriteLine("2:{0}", (total - 120));

            }
            else if (total >= 120 && total < 179 && (total - 120) < 10)
            {
                Console.WriteLine("2:0{0}", (total - 120));

         

            }

            else if (total < 10)
                Console.WriteLine("0:0" + total);





        }
    }
}
