using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    
        class Program
        {
            static void Main()
            {
                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
             
                var query = from x in numbers
                            group x by x % 2 into partition
                            select new { Key = partition.Key, Count = partition.Count(), Group = partition };

                foreach (var item in query)
                {
                        Console.WriteLine("mod2 == {0}", item.Key);
                        Console.WriteLine("Count == {0}", item.Count);

                    foreach (var number in item.Group)
                        Console.Write("{0}, ", number);
                        Console.WriteLine("\n");
                }

               
                Console.ReadKey();
            }
        }
    }
