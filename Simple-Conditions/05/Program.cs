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
            var number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double numberM = 0.0;


            if (from == "mm")

            {
                numberM = number / 1000;
            }
            else if (from == "m")
            {
                numberM = number;
            }
            else if (from == "cm")
            {
                numberM = number / 100;
            }
            else if (from == "mi")
                {
                    numberM = number / 0.000621371192;
               }
            else if (from == "in")
                    {
                        numberM = number / 39.3700787;
                    }
            else if (from == "km")
                        {
                            numberM = number / 0.001;
                        }
            else if (from == "ft")
                            {
                                numberM = number / 3.2808399;
                            }
            else if (from == "yd")
                                {
                                    numberM = number / 1.0936133;
                                }
           
            var numberB = 0.0;

            if (to == "mm")
                                     {
                                        numberB = numberM * 1000;
                                     }
            else if (to == "m")
            {
                numberB = numberM * 1;
            }
            else if (to == "cm")
                                        {
                                            numberB = numberM * 100;
                                        }
            else if (to == "mi")
                                            {
                                                numberB = numberM * 0.000621371192;
                                            }
            else if (to == "in")
                                                {
                                                    numberB = numberM * 39.3700787;
                                                 }
            else if (to == "km")
                                                    {
                                                        numberB = numberM * 0.001;
                                                    }
            else if (to == "ft")
                                                        {
                                                            numberB = numberM * 3.2808399;
                                                         }
            else if (to == "yd")

                numberB = numberM * 1.0936133;
           
           
            Console.WriteLine( "{0} {1}" , numberB, to );

             


        }
    }
}
