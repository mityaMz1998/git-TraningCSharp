using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public delegate int OperationLambda(int x, int y);
    public class LambdaExpressions
    {
        public OperationLambda multiply = (x, y) => x * y;
    }
}
