using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumL = 0;
            for (int i = 0; i < n; i++)
            
                 sumL = sumL+ int.Parse(Console.ReadLine());

            var sumR = 0;
            for (int i = 0; i < n; i++)

                sumR = sumR + int.Parse(Console.ReadLine());
            int diff = Math.Abs(sumL - sumR);
            if (sumR == sumL)
                Console.WriteLine("Yes,sum = " + sumL);
            
            else Console.WriteLine("No, diff = " + diff );
                   
                   
                }


        }
    }


