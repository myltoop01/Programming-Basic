﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double area = (a * h) / 2;
            area =  Math.Round(area, 2);
            Console.WriteLine("area=" + area);


        }
    }
}
