using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Основные и фоновые потоки. По умолчанию свойство IsBackground равно false.

namespace Threads
{
    class Program
    {
        // Метод, который планируется выполнять в отдельном потоке.
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(500);
            }
        }

        static void Main()
        {
            // Работа вторичного потока.
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            // Работа первичного потока.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }

            // Завершить работу вторичного потока
            //thread.IsBackground = true;
        }
    }
}



