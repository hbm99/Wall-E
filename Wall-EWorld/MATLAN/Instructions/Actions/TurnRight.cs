using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class TurnRight : Instruction
    {
        public TurnRight(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.TurnRight();
        }
        public override string ToString()
        {
            return "right";
        }
    }
}
