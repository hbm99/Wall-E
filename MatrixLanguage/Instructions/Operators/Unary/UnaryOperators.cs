using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    abstract class UnaryOperators : Operator
    {
        public UnaryOperators(int operand) : base(1) 
        {
            operands[0] = operand;
        }
    }
}
