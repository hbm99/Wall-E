using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.FlowDirections
{
    class Branch : Instruction
    {
        public override void Run()
        {
            if (robot.RobotStack.Pop() == 0)
            {
                if (currentRoutine.Current.Direction == 0)
                    currentRoutine.Current.Direction = 3;
                else currentRoutine.Current.Direction--;
            }
            else
            {
                if (currentRoutine.Current.Direction == 3)
                    currentRoutine.Current.Direction = 0;
                else currentRoutine.Current.Direction++;
            }
        }
    }
}
