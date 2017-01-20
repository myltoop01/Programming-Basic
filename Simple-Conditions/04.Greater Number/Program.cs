using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse (Console.ReadLine());
            int numberA = int.Parse (Console.ReadLine());
            if (number >= numberA)
                Console.WriteLine(number);
            else Console.WriteLine(numberA);
        }
    }
}
