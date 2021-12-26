using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.RobotMemory
{
    class GetAt : Instruction
    {
        /// <summary>
        /// Stacks the array value of the position indicated by the top element of the Stack
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(robot.Memory[robot.RobotStack.Pop()]);
        }
    }
}
