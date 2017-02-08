using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
   class JuniorClass : BaseClass
    {
        public bool hybrid;
        public bool electromobile;
        public JuniorClass( int petro,bool hybrid,bool electromobile, string carnamel, string country, int volumeEngine):base(carname,petrol,country,volumeEngine)
            //base(string  carname, int petrol, string country, int volumeEngine)
        {
            Console.WriteLine("b");
            this.hybrid = hybrid;
            this.electromobile = electromobile;
        }
    }





}
