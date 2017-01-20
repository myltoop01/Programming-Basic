using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            string c  =   Console.ReadLine();

     if ((c == "+" || c == "-" || c == "*") && (c == "+" && (a + b) % 2 == 0))
           
                 {
                    Console.Write("{0} + {1} = " + (a + b), a, b);
                    Console.WriteLine(" - even");
                 }
            if ((c == "+" || c == "-" || c == "*") && (c == "+" && (a + b) % 2 != 0))
                { 
                    Console.Write("{0} + {1} = " + (a + b), a, b);
                    Console.WriteLine(" - odd");
                 }

             if ((c == "+" || c == "-" || c == "*") && (c == "-" && (a - b) % 2 == 0))
              {
                Console.Write("{0} - {1} = " + (a - b), a, b);
                Console.WriteLine(" - even");
            
              }
              if ((c == "+" || c == "-" || c == "*") && (c == "-" && (a - b) % 2 != 0))
              {
                Console.Write("{0} - {1} = " + (a - b), a, b);
                Console.WriteLine(" - odd");
               }
            if ((c == "+" || c == "-" || c == "*") && (c == "*" && (a * b) % 2 == 0))
            {
                Console.Write("{0} * {1} = " + (a * b), a, b);
                Console.WriteLine(" - even");

            }
            if ((c == "+" || c == "-" || c == "*") && (c == "*" && (a * b) % 2 != 0))
            {
                Console.Write("{0} * {1} = " + (a * b), a, b);
                Console.WriteLine(" - odd");
            }
            if ((c == "%" || c == "/") && (b == 0))
            {
                Console.WriteLine("Cannot divide {0} by zero", a);
            }
            else if (c == "/")
            {
                Console.WriteLine("{0} / {1} = {2:f2}", a, b, (a / b));
            }
            else if (c == "%")
            {
                Console.WriteLine("{0} % {1} = {2}", a, b, (a % b));
            }




        }
    }
     }
  

