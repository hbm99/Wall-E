using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class SetA : Instruction
    {
        public SetA(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['A'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setA";
        }
    }
}
