using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string digit = " ";

            if (number == 1)
            {
                digit = "one";
            }
            else if (number == 2)
            {
                digit = "two";
            }
            else if (number == 3)
            {
                digit = "three";
            }
            else if (number == 4)
            {
                digit = "four";
            }
            else if (number == 5)
            {
                digit = "five";
            }
            else if (number == 6)
            {
                digit = "six";
            }
            else if (number == 7)
            {
                digit = "seven";
            }
            else if (number == 8)
            {
                digit = "eight";
            }
            else if (number == 9)
            {
                digit = "nine";
            }
            else if (number == 10)
            {
                digit = "number too big";
            }
            else if (number > 10)
            {
                digit = "number too big";
            }
            Console.WriteLine (digit);


        }
    }
}
