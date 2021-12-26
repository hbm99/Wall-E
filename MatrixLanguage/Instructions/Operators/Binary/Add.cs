using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    class Add : BinaryOperators
    {
        public Add(int left, int right) : base(left, right) 
        {
        }

        public override void Evaluate()
        {
            robot.RobotStack.Push(operands[0] + operands[1]);
        }
    }
}
