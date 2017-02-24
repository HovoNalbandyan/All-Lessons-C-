using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions   
    {
        class Program
        {
            static void Main()
            {
                int a = 1, n = 2;
            Exception d = new Exception("Try Normally nuber");
                try
                {
                ////Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("Попытка деления на ноль.");
                //Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
                if (a > n)
                {
                    Console.WriteLine("a:{0}",a);
                }
                else
                    throw new Exception() ;
                }
                catch (Exception e)
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Обработка исключения.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                //Console.ForegroundColor = ConsoleColor.Gray;
                //Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Finnaly Block");
                }

                Console.WriteLine("Press any key...");

                // Delay.
                Console.ReadKey();
            }
        }
    }
