using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            var vPool = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var poolFull = (p1 * h) + (p2 * h);
            var owerFlovs = (poolFull - vPool);
            var poolFullAll = (poolFull / vPool) * 100;
            
            var poolFullP1 = ((p1*h) / poolFull) * 100;
           
            var poolFullP2 = ((p2*h) / poolFull) * 100;
           
            if (poolFull <= vPool)
            
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate (poolFullAll), Math.Truncate(poolFullP1), Math.Truncate(poolFullP2));
            
            else 
            
                  
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, owerFlovs);
                 
        }
    }
}
