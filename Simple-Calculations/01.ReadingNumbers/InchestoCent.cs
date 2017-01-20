using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReadingNumbers
{
    class InchestoCent
    {
        static void Main(string[] args)
        {
            double number =  double.Parse (Console.ReadLine());
            Console.WriteLine("Стойността на числото в сантиметри = " + number * 2.54);
        }
    }
}
