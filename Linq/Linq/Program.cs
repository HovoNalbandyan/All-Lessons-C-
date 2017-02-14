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

//public class Employee
//{
//    public string LastName { get; set; }
//    public string FirstName { get; set; }
//    public string Nationality { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        // Построить коллекцию сотрудников с национальностями.
//        var employees = new List<Employee>
//            {
//                new Employee {LastName = "Andreev", FirstName = "Andrew",  Nationality = "Ukrainian"},
//                new Employee {LastName = "Ivanov",  FirstName = "Ivan",    Nationality = "Russian"},
//                new Employee {LastName = "Andreev", FirstName = "Ivan",  Nationality = "Ukrainian"},
//                new Employee {LastName = "Petrov",  FirstName = "Petr",    Nationality = "American"},
//                new Employee {LastName = "Andreev", FirstName = "Sergey",  Nationality = "Ukrainian"},
//                new Employee {LastName = "Petrov",  FirstName = "Slava",    Nationality = "American"}
//            };

//        // Построить запрос.
//        var query = from emp in employees
//                    group emp by new { Nationality = emp.Nationality, LastName = emp.LastName };

//        foreach (var group in query)
//        {
//            Console.WriteLine(group.Key);

//            foreach (var employee in group)
//                Console.WriteLine(employee.FirstName);
//        }

//        // Delay.
//        Console.ReadKey();
//    }
//}
//}
