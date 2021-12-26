using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class SaveRoutine : Instruction
    {
        public SaveRoutine(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.RoutineStack.Peek().indexRoutineList);
        }
        public override string ToString()
        {
            return "routine";
        }
    }
}
