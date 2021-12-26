using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Drop : Instruction
    {
        public Drop(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.Drop();
        }

        public override string ToString()
        {
            return "drop";
        }
    }
}
