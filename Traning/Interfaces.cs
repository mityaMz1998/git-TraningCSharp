﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public interface Interfaces
    {
        // Интерфейсы могут поддерживать методы, свойства, индексаторы, события,
        // статические поля и константы(начиная с версии C# 8), но не могут поддерживать нестатические поля.
        // Если у свойств и методов интерфейса модификторы доступа private, то они должны иметь реализацию по умолчанию

        // Отличия интерфейса от класса:
        // 1) Если члены интерфейса не имеют модификаторов доступа, то по умолчанию они public (у классов private)


        // Что общего у интерфейсов и астрактных классов:
        // 1) Не могут создать объект;

        // Отличия интерфейса от абстрактного класса:
        // 1) Интерфейс не содержит конструктор;
        // 2) В интерфейсах закрытые методы и свойства должны иметь реализацию по умолчанию, а абстрактные нет;
        // 3) Методы и свойства интерфейса не нужно переопределять с помощью override;
        // 4) Интерфейсы не могут содержать нестатичесие поля;
        // 5) Классы могут поддерживать множественное наследование интерфейсов, в то время как у абстрактного класса может наследоваться один раз;
        // 6) Члены интерфейса могут иметь реализацию по умолчанию;
    }
    public interface IMovable
    {
        //public int f;
        const int minSpeed = 0;
        static int maxSpeed = 70;
        void Move();
        void Stop()
        {
            Console.WriteLine("Стоп");
        }
        string Name { get; set; }
        //delegate void MoveHandler(string message);                                               
        //event MoveHandler MoveEvent; 
    }
    public interface IFigure
    {
        string Name { get; set; }
        //public IMovable()
        //{
        //}
        double CalcArea();
        double CalcPerimetr();
    }

    public class Car : IMovable
    {
        //public string Name { get { return "Audi"; }}
        public string Name { get; set; }
        public void Move() 
        {
            Console.WriteLine("Move");
        }
    }
    public class Circle : IFigure
    {
        public double radius;
        public string Name { get; set; }
        public Circle(int r, string n) 
        {
            radius = r;
            Name = n;
        }
        public double CalcArea() 
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double CalcPerimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
    public class Square : IFigure
    {
        public int side;
        public string Name { get; set; }
        public Square(int side, string name)
        {
            this.side = side;
            Name = name;
        }
        public double CalcArea()
        {
            return Math.Pow(side, 2);
        }
        public double CalcPerimetr()
        {
            return 4 * side;
        }
    }
}