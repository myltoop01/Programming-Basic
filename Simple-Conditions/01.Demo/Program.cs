using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            if (number >= 5.5 && number <= 6.0)
                Console.WriteLine("Excellent!");
           else if (number < 5.5) 
            Console.WriteLine("Not excellent.");


        }
    }
}
