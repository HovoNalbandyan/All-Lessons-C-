using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2

{
    public delegate void MyDelegate();


    class Program
    {
        static void Main(string[] args)
        {
            ClassEvent instance = new ClassEvent();

            instance.MyEvent += new MyDelegate(InEvent1);
            instance.MyEvent += new MyDelegate(InEvent2);
            instance.MyEvent += delegate { Console.WriteLine("------------------1-----------------"); };
            instance.InvokeEvent();
            //// Delete InEvent 2 from Delegate.
            instance.MyEvent -= new MyDelegate(InEvent2);
            // Невозможно открепить ранее присоединенный анонимный метод.
            instance.MyEvent -= delegate { Console.WriteLine("--------------2-----------------"); };
            instance.InvokeEvent();
            instance.MyEvent += new MyDelegate(function1);
            instance.MyEvent += new MyDelegate(function2);
            instance.InvokeEvent();
            

            // Delay.
            Console.ReadKey();
        }
        public static void function1()
        {

            Console.WriteLine("First Function Method");

        }
        public static void function2()
        {

            Console.WriteLine("Second Function Method");

        }
        private static void InEvent1()
        {

            Console.WriteLine("In Event 1");
        }

        private static void InEvent2()
        {
            Console.WriteLine("In Event 2");
        }
        
    }

}
