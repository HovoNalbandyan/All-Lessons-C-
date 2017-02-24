using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    
    // Получение информации о директории.   
        class Program
        {
            static void Main()
            {
                // Экземпляр класса DirectoryInfo, ссылается на директорию - C:\Windows\assembly. 
                var directory = new DirectoryInfo(@"C:\Windows\assembly");
    Console.WriteLine("FullName : Name :CreationTime : Attributes  :LastAccessTime :LastWriteTime :");
                if (directory.Exists) // Если указанная директория существует, то выводим о ней информацию.
                {
                Console.Write(directory.FullName, directory.Name, directory.CreationTime, directory.Attributes.ToString(), directory.LastAccessTime, directory.LastWriteTime);
                    //Console.WriteLine("FullName      : {0}", directory.FullName);              // Полное Имя директории, (включая путь).
                    //Console.WriteLine("Name          : {0}", directory.Name);                  // Имя директории, (НЕ включая путь).
                    //Console.WriteLine("CreationTime  : {0}", directory.CreationTime);          // Время создания директории.
                    //Console.WriteLine("Attributes    : {0}", directory.Attributes.ToString()); // Аттрибуты.
                    //Console.WriteLine("LastAccessTime: {0}", directory.LastAccessTime);        // Время последнего доступа к директории.
                    //Console.WriteLine("LastWriteTime : {0}", directory.LastWriteTime);         // Время последнего изменения файлов в директории.                 
                }
                else
                {
                    Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
                }



                // Delay.
                Console.ReadKey();
            }
        }
    }
