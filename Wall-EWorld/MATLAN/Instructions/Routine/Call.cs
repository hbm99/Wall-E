using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Call : Instruction
    {
        public Call(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RoutineStack.Push((MatrixLanguageMap)robot.RoutineList[robot.RobotStack.Pop()].Clone());
        }
        public override string ToString()
        {
            return "call";
        }
    }
}
