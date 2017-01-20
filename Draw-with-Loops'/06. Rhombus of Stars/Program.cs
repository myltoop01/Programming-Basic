using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

           
      
            for (int currentRow = 0; currentRow < n; currentRow++)
            {
                for (int currentCol = 0; currentCol < n - (currentRow + 1); currentCol++)
                {
                    Console.Write(' ');
                }
                for (int currenCol = 0; currenCol <= currentRow; currenCol++)

                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int currentRow = 0; currentRow < n - 1; currentRow++)
            {
                for (int currentCol = 0; currentCol < (currentRow + 1); currentCol++)
                
                    Console.Write(" ");
                for (int currentCol = 0; currentCol < (n-1-currentRow); currentCol++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();


            }
       }
     }
  }



    


