﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10x10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i =0; i < 10; i++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            }
        }
    }

