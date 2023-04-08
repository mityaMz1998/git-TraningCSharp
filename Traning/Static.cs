using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class Static
    {
        // Структуры не могут быть статическими:

        // Статические члены хранят значения (применяются) для всех объектов класса/структуры
        // Память для статических переменных выделяется даже в том случае, если не создано ни одного объекта этого класса

        //Отличия статического класса от обычного:
        //1)Если мы хотим обраться к члену класса, то мы можем это сделать через экземпляр класса; а если обратиться к 
        // статическому члену класса, то можно сделать через имя класса;
        //2)Если класс статический, то и его члены должны быть статическими; у обычного класса члены могут быть и статическими, и нестатическими;
        //3)У статического класса нельзя создать объект;

        // Статические конструкторы:
        // 1)Статические конструкторы не должны иметь модификатор доступа и не принимают параметров;
        // 2)Как и в статических методах, в статических конструкторах нельзя использовать ключевое слово this
        // для ссылки на текущий объект класса и можно обращаться только к статическим членам класса;
        // 3)Статические конструкторы нельзя вызвать в программе вручную.
        // Они выполняются автоматически при самом первом создании объекта данного класса или при первом
        // обращении к его статическим членам (если таковые имеются);
    }

    class K
    {
        public int a;
        public static int u = 25;

        static K()
        {
            Console.WriteLine("K1");
        }
        public K()
        {
            Console.WriteLine("K2");
        }
        public K(int a)
        {
            this.a = a;
            Console.WriteLine("K3");
        }

        static string k { get; set; }

        public void Bn()
        {
            Console.WriteLine("MethodK");
        }


    }
    static class L
    {
        public static string s = "jjj";

        static L()
        {
            Console.WriteLine("L1");
        }
        public static void f()
        {
            Console.WriteLine("L");
        }
    }

    struct M
    {
        static int e = 1;
        public static int f = 2;

        static M()
        {
            Console.WriteLine("StaticM");
        }

        public M() 
        {
            Console.WriteLine("NoStaticM");
        }

        public int structM()
        {
            return f;
        }

        public static void m()
        {
            Console.WriteLine("M");
        }
    }
}
