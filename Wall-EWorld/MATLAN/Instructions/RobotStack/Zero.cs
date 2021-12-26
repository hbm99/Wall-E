using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Zero : Instruction
    {
        public Zero(Robot robot) : base(robot)
        {
        }

        /// <summary>
        /// Takes the Stack's top value and stacks its double
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(robot.RobotStack.Pop() * 2);
        }
        public override string ToString()
        {
            return "zero";
        }
    }
}
