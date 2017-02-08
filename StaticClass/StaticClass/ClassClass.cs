using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class ClassClass
    {
        public static int a = 9;
        public static int b = 8;

        public static int calc()
        {

            return a * b;
        }
        static ClassClass()
        {

        }

       
    }
}
