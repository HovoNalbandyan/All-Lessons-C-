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
            int a = 7;
            int b = 8;
            ClassClass.a = a;                        //input static class method Field
            ClassClass.b = b;                        //input static class method Field

            Console.WriteLine(ClassClass.calc());   //print to console result of calc method
            ClassClass.a = 12;                      //initialization argument of calc method()
            ClassClass.b = 8;                       //initialization argument of calc method()
            Console.WriteLine(ClassClass.calc());   //print to console result of calc method



        }
    }
}
