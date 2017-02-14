using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class ClassClass
    {
        public static int a=8 ;    //Public Class Field must be static Type
        public static int b=8 ;    //Default parameters

        public static int calc()    ////Public Class methods() must be static Type
        {             
            return a * b;
        }
       
        //ctor      
        static ClassClass()
        {

        }
        
       
    }
}
