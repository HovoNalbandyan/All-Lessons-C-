using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            Thread a = new Thread(writeSecond);
            a.Start();
           

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



