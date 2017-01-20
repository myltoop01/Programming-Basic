using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Генератор_на_тъпи_пароли
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int i1 = 1; i1 <= n; i1++)
                {
                    for (var i2 = 'a'; i2 < 'a' + a; i2++)
                    {
                        for (var i3 = 'a'; i3 < 'a' + a; i3++)
                        {
                            for (int i4 = Math.Max(i, i1) + 1; i4 <= n; i4++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, i1, i2, i3, i4);

                            }
                        }
                    }
                }
            }                           
        }
    }
}
