using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Ternary : TernaryOperator
    {
        public Ternary(Robot robot) : base(robot)
        {
        }

        public override void Evaluate(params int[] operands)
        {
            if (operands[2] != 0)
                robot.RobotStack.Push(operands[1]);
            else robot.RobotStack.Push(operands[0]);
        }
        public override string ToString()
        {
            return "ternary";
        }
    }
}
