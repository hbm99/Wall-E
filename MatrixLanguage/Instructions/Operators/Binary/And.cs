using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    class And : BinaryOperators
    {
        public And(int left, int right) : base(left, right)
        {
        }

        public override void Evaluate()
        {
            if (operands[0] != 0 && operands[1] != 0) 
                robot.RobotStack.Push(1);
            else robot.RobotStack.Push(0);
        }
    }
}
