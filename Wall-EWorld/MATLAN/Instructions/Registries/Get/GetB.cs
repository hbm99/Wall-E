using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetB : Instruction
    {
        public GetB(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['B']);
        }
        public override string ToString()
        {
            return "getB";
        }
    }
}
