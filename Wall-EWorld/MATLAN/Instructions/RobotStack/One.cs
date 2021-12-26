using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class One : Instruction
    {
        public One(Robot robot) : base(robot)
        {
        }

        /// <summary>
        /// Takes the Stack's top value and stacks its double + 1
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(robot.RobotStack.Pop() * 2 + 1);
        }
        public override string ToString()
        {
            return "one";
        }
    }
}
