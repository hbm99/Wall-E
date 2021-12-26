using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class RecCall : Instruction
    {
        public RecCall(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.RoutineStack.Peek().indexRoutineList);
            robot.RoutineStack.Push(robot.RoutineList[robot.RobotStack.Pop()]);
        }
        public override string ToString()
        {
            return "recCall";
        }
    }
}
