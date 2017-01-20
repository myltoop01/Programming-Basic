using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fibNum1 = 1;
            var fibNum2 = 1;
            
          //  if (n < 2) Console.WriteLine("1");
            for (int i = 0; i < n-1; i++)
            {
                var sum = fibNum1 + fibNum2;
               
                fibNum1 = fibNum2;
                fibNum2 = sum;

            }
            Console.WriteLine(fibNum2);
        }
    }
}
