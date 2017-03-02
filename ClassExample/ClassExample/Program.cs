using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
   public  class Program
    {
        public static void Main(string[] args)
        {

            //Console.Write("A= ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("B= ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("C= ");
            //double c = double.Parse(Console.ReadLine());
            //Triangle hashv1 = new Triangle(a, b, c);          
            //double d = hashv1.Paragic();//object for paragic method()           
            //Console.WriteLine("Paragic="+d);


            Triangle t1 = new Triangle(5,5,5);          
            Console.WriteLine("Paragic="+t1.Paragic());
            Console.WriteLine("Area="+t1.Area());
            Console.WriteLine("'---------------'");
            
            
            //double d1 = hashv1.Area();//object for aRea method()
            //Console.WriteLine("Area="+d1);
            //Console.ReadLine();
        }

    }
}
