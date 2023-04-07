using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class GenericsTypes
    {
        //Обобщенные типы позволяют указать конкретный тип, который будет использоваться.

        //Обобщения позволяют избегать преобразований;

        //Ограничения обобщений:
        //Ограничения методов указываются после списка параметров после оператора where.
        //После оператора where указывается универсальный параметр, для которого применяется ограничение.
    }
    class User<T>
    {
        public static T? i;
        public T Id { get; set; }
        public string Name { get; set; }

        public User(T id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString() 
        {
            return $"{Id}-{Name}";
        }
    }
    class UniversalUser<T> : User<T>
    {
        public UniversalUser(T id, string name) : base(id, name) 
        { }
    }
    class IntUser<T> : User<int>
    {
        public IntUser(int id, string name) : base(id, name)
        { }
    }
}
