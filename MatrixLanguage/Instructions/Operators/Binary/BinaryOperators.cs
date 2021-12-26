using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    abstract class BinaryOperators : Operator
    {
        public BinaryOperators(int left, int right) : base(2) //revisar ctor d binary,unary....
        {
            operands[0] = left;
            operands[1] = right;
        }
    }
}
