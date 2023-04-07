using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class Encapsulation
    {
        //В отличие от переопределения C# позволяет применять скрытие к переменным (как к статическим, так и нестатическим)
        //и константам, также используя ключевое слово new

    }
    class G
    {
        public readonly static int minAge = 1;
        public const string typeName = "Person";
    }
    class H : G
    {
        // скрываем поля и константы базового класса
        public new readonly static int minAge = 18;
        public new const string typeName = "Employee";
    }
}
