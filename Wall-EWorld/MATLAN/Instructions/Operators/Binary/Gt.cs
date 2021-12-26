using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Gt : BinaryOperators
    {
        public Gt(Robot robot) : base(robot)
        {
        }

        public override void Evaluate(params int[] operands)
        {

            if (operands[1] > operands[0]) 
                robot.RobotStack.Push(1);
            else robot.RobotStack.Push(0);

        }
        public override string ToString()
        {
            return "gt";
        }
    }
}
