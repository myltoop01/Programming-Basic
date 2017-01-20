using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");

            Console.WriteLine();
            for (int a = 1; a <= n-2 ; a++)
            {
              
              
                    Console.Write("| ");
                    for (int i = 0; i < n-2; i++)
                    {
                        Console.Write("- ");

                    }
                    
                    Console.Write("|");
                    Console.WriteLine();


               
            }

            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();

        }
    }
}
