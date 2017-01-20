using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            string speed = string.Empty;
            if (number <= 10)
                speed = ("slow");
            else if (number > 10 && number <=50)
                speed = ("average");
            else if (number > 50 && number <= 150)
                speed = ("fast");
            else if (number > 150 && number <= 1000)
                speed = ("ultra fast");
            else if (number > 1000 )
                speed = ("extremely fast");
            Console.WriteLine("{0}", speed);


        }
    }
}
