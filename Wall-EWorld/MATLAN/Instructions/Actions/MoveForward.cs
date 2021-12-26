using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class MoveForward : Instruction
    {
        public MoveForward(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.MoveForward();
        }
        public override string ToString()
        {
            return "forward";
        }
    }
}
