using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    //public delegate void ThreadStart();
    internal class Multithreading
    {
        // В класс Thread обязательно в качестве параметра передается делегат ThreadStart, у которого нет возвращаемого значения
        // и параметров.
        // Или также передается делегат ParameterizedThreadStart, у которого нет возвращаемого значения, но имеются параметры.

        //Оператор lock определяет блок кода, внутри которого весь код блокируется и становится недоступным для 
        //других потоков до завершения работы текущего потока.Остальный потоки помещаются в очередь ожидания и ждут, 
        //пока текущий поток не освободит данный блок кода.

        //Наряду с оператором lock для синхронизации потоков мы можем использовать мониторы, 
        //представленные классом System.Threading.Monitor.
    }
    class Thr
    {
        public void SecondThread()
        {
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine("2-ой поток:");
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void ThirdThread(object? y)
        {
            if (y is int h)
            {
                for (int i = 3; i < h; i++)
                {
                    Console.WriteLine("3-й поток:");
                    Console.Write(i);
                    Thread.Sleep(500);
                }
            }
        }
    }
}
