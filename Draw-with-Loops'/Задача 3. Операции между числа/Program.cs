using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            if (c == "+")
            {
                if ((a + b) % 2 == 0)
                {
                    Console.WriteLine(a + " + " + b + " = " + (a + b) + " - even");
                }
                else Console.WriteLine(a + " + " + b + " = " + (a + b) + " - odd");
            }
            if (c == "-")
            {
                if ((a - b) % 2 == 0)
                {
                    Console.WriteLine(a + " - " + b + " = " + (a - b) + " - even");
                }
                else Console.WriteLine(a + " - " + b + " = " + (a - b) + " - odd");
            }
            if (c == "*")
            {
                if ((a * b) % 2 == 0)
                {
                    Console.WriteLine(a + " * " + b + " = " + (a * b) + " - even");
                }
                else Console.WriteLine(a + " * " + b + " = " + (a * b) + " - odd");
            }
            if (c == "/" && b != 0 || c == "%" && b != 0)
            {
                if (c == "/")

                {
                    Console.WriteLine("{0} {1} {2} {3} {4:f2}", a, c, b, "=", (a / b));
                }

                else Console.WriteLine("{0} {1} {2} {3} {4}", a, c, b, "=", (a % b));
            }
            if (c == "/" && b == 0 || c == "%" && b == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", a);
            }

            
        }   

    }
}
