using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var aB =  (a  >= 100 && a <= 200 || a == 0);
            if (!aB)
                Console.WriteLine("invalid");


        }
    }
}
