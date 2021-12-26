using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.RobotStack
{
    class One : Instruction
    {
        /// <summary>
        /// Takes the Stack's top value and stacks its double + 1
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(robot.RobotStack.Pop() * 2 + 1);
        }
    }
}
