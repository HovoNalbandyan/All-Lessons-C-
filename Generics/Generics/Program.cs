using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Generics
    {
        class MyGenerics<TYPE1, TYPE2>

        {
            // Поля
            private TYPE1 k1;
            private TYPE2 k2;
            // Конструктор.
            public MyGenerics(TYPE1 argument1, TYPE2 argument2)
            {
                this.k1 = argument1;
                this.k2 = argument2;
            }

        // Свойства.
        public TYPE1 Variable1
        {
            get { return this.k1; }
            set { this.k1 = value; }
        }

        public TYPE2 Variable2
        {
            get { return this.k2; }
            set { this.k2 = value; }
        }
    }
    class Program
        {
            static void Main()
            {
                MyGenerics<int, int> instance1 = new MyGenerics<int, int>(1, 2);
                Console.WriteLine(instance1.Variable1 + instance1.Variable2);            

                MyGenerics<string, int> instance2 = new MyGenerics<string, int>("Number", 1);
                Console.WriteLine(instance2.Variable1 + instance2.Variable2);

                MyGenerics<string, string> instance3 = new MyGenerics<string, string>("Hello ", "World");
                Console.WriteLine(instance3.Variable1 + instance3.Variable2);

            string a = "Zohrab";
            string b = a;
            Console.WriteLine(b);
            a = "Rostam";
            Console.WriteLine(b);

                // Delay.
                Console.ReadKey();
          
            }
        }
    }

