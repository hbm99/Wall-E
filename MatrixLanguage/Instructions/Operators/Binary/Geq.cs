using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    class Geq : BinaryOperators
    {
        public Geq(int left, int right) : base(left, right)
        {
        }

        public override void Evaluate()
        {
            if (operands[1] >= operands[0])
                robot.RobotStack.Push(1);
            else robot.RobotStack.Push(0);

        }
    }
}
