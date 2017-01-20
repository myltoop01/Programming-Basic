using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var bigNum = -10000000000;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > bigNum)
                    bigNum = num;

            }
            if (bigNum == sum - bigNum)

            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + bigNum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(bigNum-(sum-bigNum)));
            }
        }
    }
}
