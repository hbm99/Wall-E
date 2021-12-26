using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class GetY : Instruction
    {
        public GetY(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['Y']);
        }
        public override string ToString()
        {
            return "getY";
        }
    }
}
