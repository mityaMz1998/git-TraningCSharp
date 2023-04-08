using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public class ReferencesAndValuesTypes
    {
        public int a = 5;
        public string str = "Abcd";
        public static void CalculateValue(int t)
        {
            int x = 6;
            int y = 7;
            int z = y + t;
        }
        public static void CalculateReference(string s)
        {
            string s1 = "How ";
            string s2 = "are ";
            string s3 = s2 + s;
            //Console.WriteLine(s3);
        }
        public int Calculate1(int t)
        {
            object x = 6;
            int y = 7;
            int z = y + t;
            return z;
        }

        public int Calculate(int b)
        {
            b = 3;
            return a + b;
        }
        public int CalculateIn(in int d)
        {
            //d = 1; // нельзя вносить изменения
            return d + a;
        }
        public int CalculateR(ref int d)
        {
            return d + a;
        }
        public int CalculateRef(ref int b)
        {
            b = 3;
            return a + b;
        }
        public string Result(string c)
        {
            c = "efg";
            return str + c;
        }
        public string ResultRef(ref string c)
        {
            c = "efg";
            return str + c;
        }
    }

    struct State
    {
        public int x;
        public int y;

        public Country country;
        public State()
        {
            x = 0;
            y = 0;
            country = new Country();
        }
    }

    class Country
    {
        public int x;
        public int y;
    }
    //class Person
    //{
    //    public string name = "";
    //    public int age;
    //}
}
