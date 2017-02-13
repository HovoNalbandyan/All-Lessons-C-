using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace InterIEnumerable
{
    class Program
    {
        static void Main()
        {
            UserCollection myCollection = new UserCollection();
            foreach (Element element in myCollection)
            {
                //Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
                Console.WriteLine("Gago:{0}","aaa");
                Console.WriteLine("jj");
            }

            //myCollection.Reset(); //
            Console.Write(new string('-', 29) + "\n");
            // Используем foreach, для повторного обращения к каждому объекту Element внутри массива myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.Write(new string('-', 29) + "\n"); 
            // ----------------------------------------------------------------------------------------------------------------------
            // Так работает foreach.
            UserCollection myElementsCollection = new UserCollection();
            // foreach - приводит коллекцию к интерфейсному типу IEnumerable.
            IEnumerable enumerable = myElementsCollection as IEnumerable;
            // foreach - приводит коллекцию к интерфейсному типу вызывая метод - GetEnumerator().            
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext()) // Перемещаем курсор на 1 шаг вперед (с -1 на 0) и т.д.
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
                        enumerator.Reset();
            // Задержка.
            Console.ReadKey();
        }
    }//Fock
}
