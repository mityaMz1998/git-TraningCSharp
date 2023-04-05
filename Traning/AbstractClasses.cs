using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public class AbstractClasses
    {
        // 1)В абстрактном классе, абстрактными могут быть свойства, методы, индексаторы и события;
        // 2)Абстрактные члены не могут иметь закрытый доступ (private), а также не имеют реализации;
        // 3)Абстрактные члены должны быть переопределены в классе наследнике при помощи override;
        // 4)Если в классе имеется хоть один абстрактный член, то этот класс должен быть помечен как абстрактный;
        // 5)Если в производном классе хотим отказаться от реализации члена, то тогда производный класс нужно сделать абстрактным;

        // Отличия абстрактного класса от обычного:
        // 1) У абстрактного класса нельзя создать объект (не можем использовать конструктор для создания объекта);
    }
    public abstract class Figure
    {
        //public delegate void Fig();
        //public abstract int Count { get; set; }
        //public abstract int y;
        //private abstract event Fig k;

        public string name;
        public Figure(string name)
        {
            this.name = name;
        }
        //public abstract int Radius()
        //{
        //    return 5;
        //}
        public abstract double CalcArea();

        public abstract double CalcPerimetr();       
    }
    public class Triangle : Figure
    {
        public int sideA;
        public int sideB;
        public int sideC;
        //public override int Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Triangle(string name, int sA, int sB, int sC) : base(name) 
        { 
            sideA = sA;
            sideB = sB;
            sideC = sC;
        }

        public override double CalcPerimetr()
        {
            return sideA + sideB + sideC;
        }
        public override double CalcArea()
        {
            double halfArea = (CalcPerimetr() / 2.0);
            double area = halfArea * (halfArea - sideA) * (halfArea - sideB) * (halfArea - sideC);
            return Math.Sqrt(area);
        }
    }

    public class Rectangle : Figure
    {
        public int length;
        public int width;
        //public override int Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Rectangle(string name, int length, int width) : base(name) 
        {
            this.length = length;
            this.width = width;
        }

        public override double CalcPerimetr()
        {
            return 2 * length + 2 * width;
        }
        public override double CalcArea()
        {
            double area = length * width;
            return area;
        }
    }
}
