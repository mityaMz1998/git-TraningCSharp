using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public class ReferencesAndValuesTypes
    {
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
    }
}
