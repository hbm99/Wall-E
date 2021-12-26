using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_EWorld;

namespace Wall_EWorld
{
    public abstract class Instruction
    {
        protected MatrixLanguageMap currentRoutine;
        protected Robot robot;
        public Instruction(Robot robot)
        {
            this.robot = robot;
            currentRoutine = robot.RoutineStack.Peek();
        }
        public abstract void Run();
    }
}
