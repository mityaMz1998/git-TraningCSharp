using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class ParallelProgramming
    {
        //Wait() - Ожидание выполнения задачи
    }
    static class Calculate
    {
        public static int Sum(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
        public static void Multi(int x)
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Console.WriteLine($"Результат: {x * x}");
        }
        public static void Div(int x, double y)
        {
            if (y != 0)
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Console.WriteLine($"Результат: {x / y}");
            }
            else
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Console.WriteLine("y не должен равнятся 0");
            }
        }
    }
}
