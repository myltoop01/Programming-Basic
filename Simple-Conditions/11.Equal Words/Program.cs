using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
          
            string wordA = Console.ReadLine().ToLower();
        
            if (word == wordA)
                Console.WriteLine("yes");
            else Console.WriteLine("no");

        }
    }
}
