using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sity = Console.ReadLine(). ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = -1.00;
            if (sity == "sofia") 
            {
                if (sales >= 0 && sales <= 500) comission = 0.05;
                else if (sales > 500 && sales <= 1000) comission = 0.07;
                else if (sales > 1000 && sales <= 10000) comission = 0.08;
                else if (sales > 10000 ) comission = 0.12;
            
            }
            if (sity == "varna")
            {
                if (sales >= 0 && sales <= 500) comission = 0.045;
                else if (sales > 500 && sales <= 1000) comission = 0.075;
                else if (sales > 1000 && sales <= 10000) comission = 0.10;
                else if (sales > 10000) comission = 0.13;

            }
            if (sity == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) comission = 0.055;
                else if (sales > 500 && sales <= 1000) comission = 0.08;
                else if (sales > 1000 && sales <= 10000) comission = 0.12;
                else if (sales > 10000) comission = 0.145;

            }
            if (comission < 0 )
            {
                Console.WriteLine("error");
            }
            else Console.WriteLine("{0:f2}", sales * comission);


        }
    }
}
