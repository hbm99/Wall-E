using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class SetG : Instruction 
    {
        public SetG(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['G'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setG";
        }
    }
}
