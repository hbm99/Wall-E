using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Ultrasonic : Instruction
    {
        public Ultrasonic(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.Ultrasonic());
            
        }
        public override string ToString()
        {
            return "distance";
        }
    }
}
