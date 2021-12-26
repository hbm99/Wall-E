using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    class Not : UnaryOperators
    {
        public Not(int operand) : base(operand)
        {
        }

        public override void Evaluate()
        {
            if (operands[0] == 0)
                robot.RobotStack.Push(1);
            else robot.RobotStack.Push(0);
        }
    }
}
