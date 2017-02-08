using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    
    public delegate void MyDelegate();  //first Delegate void
    public delegate int Deleg();//second delegate int

    class Program
    {
        static void Main()
        { //----------------------------First Delegate
            MyDelegate d2;
            d2 = Method1;
            d2 += Method2;
            d2();
            // Delay.
            //-----------------------------Second Delegate
            Deleg d1 = Func1;
            d1 += Func1;
            Console.WriteLine(d1());
            Func2();
            d1+=Func2;
            Console.WriteLine(d1());
           
            Console.ReadKey();
        }
        static int Func1()
        { 
            return 1;
        }

        static int Func2()
        {
            return 2;
        }

        static void Method1()
        {
            Console.WriteLine("First Method");
        }

        static void Method2()
        {
            Console.WriteLine("second method");
        }
    }
}
