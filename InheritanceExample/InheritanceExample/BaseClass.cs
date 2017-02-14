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
       
        //Constructor Default
        public BaseClass()
        {
        }
        public BaseClass(string carname,  string country)
        {
            this.country = country;           
            this.carname = carname;        
            Console.WriteLine("a");
        }


    }
}
