using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
           
        {
            var n = int.Parse(Console.ReadLine());
            var blanks = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(" ");
            }
                Console.WriteLine("*");
            for (int i = 0; i < n - 1; i++)
            {
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write(' ');
                    Console.Write("*");
                }
                
                Console.WriteLine();
                for (int b = 0; b < n - 2; b++)
                {
                    Console.Write("-*");
                }

            }
            }
            
        }
    }

