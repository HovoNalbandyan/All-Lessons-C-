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
        {  // Поля
            int fiveDigitCode;
            int plusFourExtension;
            // Свойства.
            public int FiveDigitCode
            {
                get { Console.WriteLine("axper jan tpum em"); return fiveDigitCode;  }
                set { fiveDigitCode = value; }
            }
                       
            public int PlusFourExtension
            {
                get { return plusFourExtension; }
                set { plusFourExtension = value; }
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
