using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public delegate int OperationA(int x, int y);
    public class AnonymousMethods
    {
        public OperationA operationSum = delegate (int x, int y)
        {
            return x + y;
        };

        public int OperationSum(int x, int y)
        {
            return x + y;
        }

        public OperationA operationSub = delegate (int x, int y)
        {
            return x - y;
        };

        public int OperationSub(int x, int y) => x - y;
    }
}
