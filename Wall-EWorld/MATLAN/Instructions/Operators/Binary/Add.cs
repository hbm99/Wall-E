using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Add : BinaryOperators
    {
        public Add(Robot robot) : base(robot)
        {
        }

        public override void Evaluate(params int[] values)
        {
            robot.RobotStack.Push(operands[0] + operands[1]);
        }

        public override string ToString()
        {
            return "add";
        }
    }
}
