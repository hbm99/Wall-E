using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Neq : BinaryOperators
    {
        public Neq(Robot robot) : base(robot)
        {
        }

        public override void Evaluate(params int[] operands)
        {
            if (operands[0] != operands[1])
                robot.RobotStack.Push(1);
            else robot.RobotStack.Push(0);

        }
        public override string ToString()
        {
            return "neq";
        }
    }
}
