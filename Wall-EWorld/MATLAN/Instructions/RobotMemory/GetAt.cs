using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetAt : Instruction
    {
        public GetAt(Robot robot) : base(robot)
        {
        }

        /// <summary>
        /// Stacks the array value of the position indicated by the top element of the Stack
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(robot.Memory[robot.RobotStack.Pop()]);
        }
        public override string ToString()
        {
            return "getAt";
        }
    }
}
