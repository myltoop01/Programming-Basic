﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            double deg = (rad * 180) / Math.PI;
            deg = Math.Round(deg, 0);
            Console.WriteLine(deg);

        }
    }
}
