using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Div : BinaryOperators
    {
        public Div(Robot robot) : base(robot)
        {
        }

        public override void Evaluate(params int[] operands)
        {
            robot.RobotStack.Push(operands[1] / operands[0]);
        }
        public override string ToString()
        {
            return "div";
        }
    }
}
