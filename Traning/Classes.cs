using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public class Classes
    {

    }
    public class PersonClass
    {
        public string name;
        public int age;
        public int Weihth { get; set; }
        public PersonClass(string name = "Неизвестно", int age = 18)
        {
            this.name = name;
            this.age = age;
        }
        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }
        public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
    public abstract class PersonAbstractClass
    {
        public PersonAbstractClass() 
        { }
    }
}
