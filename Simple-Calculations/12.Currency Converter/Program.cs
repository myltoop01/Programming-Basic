using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var valCurrency = float.Parse(Console.ReadLine());
            var inCurrency = (string)Console.ReadLine();
            var outCurrency = Console.ReadLine();


            if (inCurrency == "BGN")
            {
                if (outCurrency == "EUR")
                    Console.WriteLine(Math.Round(valCurrency / 1.95583, 2)+(" EUR"));
                if (outCurrency == "USD")
                    Console.WriteLine(Math.Round(valCurrency / 1.79549, 2)+(" USD"));
                if (outCurrency == "GBP")
                    Console.WriteLine(Math.Round(valCurrency / 2.53405, 2)+(" GBP"));
            }
            if (inCurrency == "EUR")
            {
                if (outCurrency == "BGN")
                    Console.WriteLine(Math.Round(valCurrency * 1.95583 ,2)+(" BGN"));
                if (outCurrency == "USD")
                    Console.WriteLine(Math.Round(valCurrency * 1.95583 / 1.79549,2)+(" USD"));
                if (outCurrency == "GBP")
                    Console.WriteLine(Math.Round(valCurrency * 1.95583 / 2.53405,2)+(" GBP"));
            }
            if (inCurrency == "USD")
            {
                if (outCurrency == "EUR")
                    Console.WriteLine(Math.Round(valCurrency * 1.79549 / 1.95583,2)+(" EUR"));
                if (outCurrency == "BGN")
                    Console.WriteLine(Math.Round(valCurrency * 1.79549,2) + " BGN");
                if (outCurrency == "GBP")
                    Console.WriteLine(Math.Round(valCurrency * 1.79549 / 2.53405,2) + " GBP");
            }
            if (inCurrency == "GBP")
            {
                if (outCurrency == "EUR")
                    Console.WriteLine(Math.Round(valCurrency * 2.53405 / 1.95583,2) + " EUR");
                if (outCurrency == "USD")
                    Console.WriteLine(Math.Round(valCurrency * 2.53405 / 1.79549 ,2)+ " USD");
                if (outCurrency == "BGN")
                    Console.WriteLine(Math.Round(valCurrency * 2.53405,2) + " BGN");

            }



        }

    }
}


