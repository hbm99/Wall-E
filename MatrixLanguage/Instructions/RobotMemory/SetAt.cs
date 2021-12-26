using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.RobotMemory
{
    class SetAt : Instruction
    {
        /// <summary>
        /// Takes from the Stack an index and a value to insert in the Robot Memory
        /// </summary>
        public override void Run()
        {
            int index = robot.RobotStack.Pop();
            int value = robot.RobotStack.Pop();
            robot.Memory[index] = value;
        }
    }
}
