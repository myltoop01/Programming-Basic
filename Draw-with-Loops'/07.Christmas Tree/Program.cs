using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                var stars = new String('*', i);
                var space = new String(' ', n-i);
                Console.Write(space);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine();


            }
       }
    }
  }

