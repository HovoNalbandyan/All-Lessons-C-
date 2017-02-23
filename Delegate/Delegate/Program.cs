using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void MyDelegate();  //first Delegate void
    public delegate int DelegateInt();//second delegate int
    public delegate double DelegateDouble();

    class Program

    {
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
        static double Print1()
        {
            int a = 7;
            int b = 9;
            return a * b;

        }
        static double Print2()
        {
            int a = 7;
            int b = 9;
            return a / b;

        }
        static void Main()
        { //----------------------------First Delegate
            MyDelegate d2;
            d2 = Method1;
            d2 += Method2;
            d2();
            // Delay.
            //-----------------------------Second Delegate
            DelegateInt d1 = Func1;
            d1 += Func1;
            Console.WriteLine(d1());
            Func2();
            d1 += Func2;
            Console.WriteLine(d1());
            //-----------   Thrird Delegate
            DelegateDouble B1 = Print1;
            B1 += Print1;
            Console.WriteLine(B1());
            B1 += Print2;
            Print2();
            Console.WriteLine(B1());// Console.WriteLine(B1(Dont error without Scobes,-Why???));

            Console.ReadLine();        
            

        }

    }
}
