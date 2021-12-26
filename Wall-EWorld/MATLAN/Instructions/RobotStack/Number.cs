using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Number : Instruction
    {
        public Number(Robot robot) : base(robot)
        {
        }

        /// <summary>
        /// Stacks value 0
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(0);
        }
        public override string ToString()
        {
            return "number";
        }

    }
}
