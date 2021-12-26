using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    class Dec : UnaryOperators
    {
        public Dec(int operand) : base(operand)
        {
        }

        public override void Evaluate()
        {
            robot.RobotStack.Push(operands[0]--);
        }
    }
}
