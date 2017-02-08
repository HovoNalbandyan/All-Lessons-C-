using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class BaseClass
    {
        public string carname;
        public string country;
        public int volumeEngine;
        protected int petrol;

        //Constructor Default
        public BaseClass()
        {

        }
        public BaseClass(string carname, int petrol, string country, int volumeEngine)
        {
            this.country = country;
            this.volumeEngine = volumeEngine;
            this.carname = carname;
            this.petrol = petrol;
            Console.WriteLine("a");
        }


    }
}
