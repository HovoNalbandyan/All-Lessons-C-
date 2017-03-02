using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void DelegateVoid();  //first Delegate void
    public delegate int DelegateInt();//second delegate int
    public delegate double DelegateDouble();

    class Program

    {
        static void Method1()
        {
            Console.WriteLine("First Method");
        }
        static void Method2()
        {
            Console.WriteLine("second method");
        }
        static int Func1()
        {
            int f = 2;
            int y = 1;
            return f * y;
        }
        static int Func2()
        {
            return 22;
        }        
        static double Print1()
        {
            int a = 1;
            int b = 3;
            return a * b;
        }
        static double Print2()
        {
            int a = 9;
            int b = 3;
            return a / b;
        }
        static void Main()
        { //----------------------------First Delegate
            DelegateVoid d1;
            d1 = Method1;
            d1 += Method2;
            d1();           
            // Delay.
            //-----------------------------Second Delegate
            DelegateInt d2;
            d2 = Func1;     
            //Console.WriteLine(d2());
            d2 += Func2;
            d2();
            //Console.WriteLine(d2());            
            //-----------Thrird Delegate
            DelegateDouble B1 ;    
            B1 = Print1;
            Console.WriteLine(B1());
            B1 += Print2;
            Console.WriteLine(B1());// Console.WriteLine(B1(Dont error without Scobes,-Why???));
            Console.ReadLine();        
            

        }

    }
}
