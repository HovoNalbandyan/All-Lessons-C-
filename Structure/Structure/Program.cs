using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
      // Структуры. 
    // Пример плохого дизайна.
    namespace Structure //value type inic katarvuma stakum obj sarqeluc heto
    {
        struct ZipCode
        { //Fields
            int fiveDigitCode;
            int plusFourExtension;
            //methods.
            public int FiveDigitCode
            {
                get { Console.WriteLine("fiveDigitCode = 1;"); return fiveDigitCode;  }
                set { fiveDigitCode = 1; }//private field
            }
                       
            public int PlusFourExtension
            {
                get { Console.WriteLine("plusFourExtension = 2;"); return plusFourExtension; }
                set { plusFourExtension = 2; }
            }
           
        }
        class Program
        {
            static void Main()
            {
                ZipCode zipCode = new ZipCode();
                zipCode.FiveDigitCode = 123459;
                zipCode.PlusFourExtension = 1234;
                Console.WriteLine(zipCode.FiveDigitCode);
                Console.WriteLine(zipCode.PlusFourExtension);

                // Delay.
                Console.ReadKey();
            }
        }
    }
}
