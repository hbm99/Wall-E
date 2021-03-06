using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetQ : Instruction
    {
        public SetQ(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['Q'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setQ";
        }
    }
}
