using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.Operators.Ternary
{
    class Ternary : TernaryOperator
    {
        public Ternary(int left, int mid, int right) : base(left, mid, right)
        {
        }

        public override void Evaluate()
        {
            if (operands[2] != 0)
                robot.RobotStack.Push(operands[1]);
            else robot.RobotStack.Push(operands[0]);
        }
    }
}
