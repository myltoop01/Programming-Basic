using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
           var dateofB = Console.ReadLine();
            var format = ("dd-MM-yyyy");


            var newDateofB = DateTime.ParseExact(dateofB, format, null);
            newDateofB = newDateofB.AddDays(999);

            Console.WriteLine(newDateofB.ToString(format));

        }
    }
}

