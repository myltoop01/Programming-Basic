using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            for (int i = a; i <= b; i++)
                for (int i2 = a; i2 <= b; i2++)
                {
                    num++;
if (num <= n)
                    {
                        Console.Write("<{0}-{1}>", i, i2);

                    }

                }
            
        }
    }
}
