using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class GetX : Instruction
    {
        public GetX(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['X']);
        }
        public override string ToString()
        {
            return "getX";
        }
    }
}
