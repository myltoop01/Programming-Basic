using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
            if (figures == "square")
            {
                var number = double.Parse(Console.ReadLine());
                var areaSquare = number * number;
                Console.WriteLine(Math.Round (areaSquare,3));
            }
            if (figures == "rectangle")
            {
                var number = double.Parse(Console.ReadLine());
                var numberA = double.Parse(Console.ReadLine());
                var areaRectangle = number * numberA;
                Console.WriteLine(Math.Round(areaRectangle, 3));
             }
            if (figures == "circle")
            {
                var number = double.Parse(Console.ReadLine());

                var areacircle = number * number * Math.PI;
                Console.WriteLine(Math.Round(areacircle, 3));
            }
            if (figures == "triangle")
            {
                var number = double.Parse(Console.ReadLine());
                var numberA = double.Parse(Console.ReadLine());
                var areatriangle = (number * numberA) /2 ;
                Console.WriteLine(Math.Round(areatriangle, 3));
            }
        }
    }
}
