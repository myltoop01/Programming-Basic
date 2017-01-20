using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var numberA = double.Parse(Console.ReadLine());
            var numberB = double.Parse(Console.ReadLine());

            if (number == numberA && numberA == numberB)
                Console.WriteLine("yes");
            else Console.WriteLine("no");

        }
    }
}
