using System;99
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 1000; i++)
            {
                if ((i + 1) % 10 == 7)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }

}
