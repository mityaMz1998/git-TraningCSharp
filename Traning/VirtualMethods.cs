using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Traning
{
    internal class VirtualMethods
    {
        //Отличия вирутальных методов и свойств класса от абстрактных:
        //1)Класс виртуальным нельзя сделать;
        //2)Виртуальные методы и св-ва класса можно переопреелить, а абстрактные нужно;
        //3)Виртуальные методы и св-ва класса в базовом классе должны иметь какую реализацию, а абстрактные нет;

        //Что общего между абстрактными и виртуальными членами класса:
        //1)Виртуальные и абстрактные члены не могут быть закрытыми (private);

        //Огрничения использования виртуальных методов
        //1)Виртуальный не может быть статическим;
        //2)Виртуальный и переопределенный методы должны иметь один и тот же модификатор доступа;
        //То есть если виртуальный метод определен с помощью модификатора public,
        //то и переопредленный метод также должен иметь модификатор public;
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
    public class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
                    : base(name)
        {
            Company = company;
        }
        //public new void Print()
        //{
        //    Console.WriteLine($"Name: {Name} Company: {Company}");
        //}
        //public override void Print()
        //{
        //    Console.WriteLine($"{Name}-{Company}");
        //}
        //private override void Print()
        //{
        //    base.Print();
        //}
    }

    public class Aaa
    {
        //public virtual int i = 5;
        public virtual string Name { get; set; }
        //public virtual void MethodAA()
        //{

        //}
        public virtual void MethodA()
        {
            Console.WriteLine("Aaaaa");
        }
    }
    public class Bbb : Aaa
    {
        public override void MethodA()
        {
            Console.WriteLine("Bbbbb");
        }
    }
    public class Ccc : Bbb
    {
        public override void MethodA()
        {
            Console.WriteLine("Ccccc");
        }
    }
}
