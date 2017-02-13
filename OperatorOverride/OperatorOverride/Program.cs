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
            Console.WriteLine("a < b = {0}", a < b);
            Console.WriteLine("a > b = {0}", a > b);
            Console.WriteLine("a <= b = {0}", a <= b);
            Console.WriteLine("a >= b = {0}", a >= b);
            Console.WriteLine(new string('-', 15));
            Point c = new Point(1, 1);
            Console.WriteLine("a <= c = {0}", a <= c);
            Console.WriteLine("a >= c = {0}", a >= c);
            // Delay.
            Console.ReadKey();
        }
    }
}
