using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.RobotStack
{
    class Zero : Instruction
    {
        /// <summary>
        /// Takes the Stack's top value and stacks its double
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(robot.RobotStack.Pop() * 2);
        }
    }
}
