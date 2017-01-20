using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string result = null;
            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;
            for (int i = 0; i < n; i++)
            {
                string answer=null;
                var numer = int.Parse(Console.ReadLine());

                if (numer % 4 == 0)
                {
                    answer = "a";
                    a++;
                }

                if (numer % 4 == 1)
                {
                    answer = "b";
                    b++;
                }

                if (numer % 4 == 2)
                {
                    answer = "c";
                    c++;
                }

                if (numer % 4 == 3)
                {
                    answer = "d";
                    d++;
                }

              result += answer + ' ';
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", a,b,c,d);
        }
    }
}
