using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class WebCam : Instruction
    {
        public WebCam(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.Webcam());
        }
        public override string ToString()
        {
            return "color";
        }
    }
}
