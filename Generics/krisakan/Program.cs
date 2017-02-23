using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krisakan
{
    class Program
    {
        static void Main(string[] args)
        {
            var aram = new Person("Aram", 27);
            SetPersonByValue(ref aram);
            aram.Print();

            Console.ReadKey();
        }
        static void SetPersonByValue(ref Person p)
        {
            p.age = 100;
            p = new Person("Meri", 20);
        }
    }
    class Person
    {
        public string name;
        public int age;
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
