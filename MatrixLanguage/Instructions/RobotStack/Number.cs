using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.RobotStack
{
    class Number : Instruction
    {
        /// <summary>
        /// Stacks value 0
        /// </summary>
        public override void Run()
        {
            robot.RobotStack.Push(0);
        }
       
    }
}
