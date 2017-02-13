using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverride
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Point f = new Point(9, 9);
            Point g = new Point(13, 13);
            Console.WriteLine("a < b = {0}", a < b);
            Console.WriteLine("a > b = {0}", a > b);
            Console.WriteLine("a <= b = {0}", a <= b);
            Console.WriteLine("a >= b = {0}", a >= b);
            Console.WriteLine(new string('-', 15));
            Point c = new Point(1, 1);
            Console.WriteLine("a <= c = {0}", a <= c);
            Console.WriteLine("a >= c = {0}", a >= c);
            Console.WriteLine(new string('-', 15));

            Console.WriteLine("f>=g={0}",f>=g);
            // Delay.
            Console.ReadKey();
            
        }
    }
}
