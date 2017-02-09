using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
           // first method
            //int a = 7;
            //int b = 8;
            //ClassClass.a = a;                        //input static class method Field
            //ClassClass.b = b;                        //input static class method Field

            /* Console.WriteLine(ClassClass.calc());*/   //print to console result of calc method

            //Second Method()
            Console.Write("Input A= ");
            ClassClass.a =int.Parse(Console.ReadLine());  //initialization argument of calc method()
            Console.Write("Input B= ");
            ClassClass.b =int.Parse(Console.ReadLine());   //initialization argument of calc method()
            Console.WriteLine(ClassClass.calc());          //print to console result of calc method



        }
    }
}
