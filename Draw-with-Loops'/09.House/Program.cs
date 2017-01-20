using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n%2==0)
            {
                stars = 2;
            }
            var leftRightBlanks = (n - stars) / 2;
           
            for (int row = 0; row < (n+1)/2; row++)
            {
                Console.Write(new string('-', leftRightBlanks));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', leftRightBlanks));
      
                leftRightBlanks--;
                stars += 2;
                Console.WriteLine();
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|" + new string('*', n - 2) + "|");
                Console.WriteLine();
            }
        }
    }
}
