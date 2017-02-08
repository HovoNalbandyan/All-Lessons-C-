using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
                                                    // Indexers
    namespace Indexers
    {
        class MyClass
        {
             int[] array = new int[50];                           //  
            public int this[int index]
            {
                get                              // Getter
                {
                    return array[index];
                }
                set                               // Setter
                {
                    array[index] = value;
                }
            }
        }

        class Program
        {
            static void Main()
            {
                MyClass my = new MyClass();

                my[0] = 1;
                my[1] = 9;
                my[2] = 3;
                my[3] = 4;
                my[4] = 55;
                Console.WriteLine(my[0]);
                Console.WriteLine(my[1]);
                Console.WriteLine(my[2]);
                Console.WriteLine(my[3]);
                Console.WriteLine(my[4]);
                                                         // Delay.
                Console.ReadKey();
            }
        }
    }

}

