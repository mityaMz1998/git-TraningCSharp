using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public class Inheritance
    {
        // При наследовании наследуются весь функционал базового класса, кроме конструкторов (с параметрами)

        // Ограничения при наследовании:
        // 1)Нельзя унаследовать от статического класса;
        // 2)Если класс помечен модификатором sealed, то он не может иметь наследников
        // 3)При наследовании модификатор доступа у производного класса должен быть таким же, как у базового класса, или строже.
        // 4)Не поддерживается множественное наследование
    }
    class Person
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person()
        {
            Name = "Tom";
            Console.WriteLine("Вызов конструктора без параметров");
        }
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; } = "";
        public Employee(string name, string company) : base(name)
        {
            Name = name;
            Company = company;
        }
    }
    class Company
    {
        public string Name { get; set; }
    }

    public class CarClass
    {
        public string Name;
        public string Country;

        public CarClass() 
        {
            //name = "Masda RX8";
            Name = "Masda RX8";
            Console.WriteLine(Name);
        }

        public CarClass(string country) : this()
        {
            Country = country;
            Console.WriteLine(Country);
        }
    }

    public class RaceCar : CarClass
    {
        int MaxSpeed;
        public RaceCar(string country, int maxSpeed) : base(country)
        {
            MaxSpeed = maxSpeed;
            Console.WriteLine(MaxSpeed);
        }
    }

    public class PoliceCar : CarClass 
    {
        int MaxSpeed;
        public PoliceCar(string country, int maxSpeed) : base(country)
        {
            MaxSpeed = maxSpeed;
            Console.WriteLine(MaxSpeed);
        }
    }
}
