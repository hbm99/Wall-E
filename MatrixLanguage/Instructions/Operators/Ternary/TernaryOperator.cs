using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    abstract class TernaryOperator : Operator
    {
        public TernaryOperator(int left, int mid, int right) : base(3) 
        {
            operands[0] = left;
            operands[1] = mid;
            operands[2] = right;
        }
    }
}
