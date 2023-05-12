using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public struct Structs
    {
    }
    public struct PersonStruct
    {
        public string name;
        public int age;
        public const int cnt = 5;
        //public int Weigth { get; set; }

        public PersonStruct() : this("Tom")
        { }
        public PersonStruct(string name) : this(name, 1)
        { }
        public PersonStruct(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    //public struct PersonAbstructStruct
    //{
    //    // Струткра в отличие от класса не может быть абстрактной
    //    // Структура не поддерживает конструктор без инициализации полей, свойств(до 11 версии C#)
    //    public PersonAbstractStruct()
    //    { }
    //}
    public struct Person5
    {
        public string name;
        public int age;
        public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
