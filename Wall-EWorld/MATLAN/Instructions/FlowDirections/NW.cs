using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class NW : Instruction
    {
        public NW(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            if (!currentRoutine.IsInside(currentRoutine.Current.Row - 1, currentRoutine.Current.Column - 1) || !currentRoutine.IsInside(currentRoutine.Current.Row, currentRoutine.Current.Column))
                robot.RoutineStack.Pop();
            if (currentRoutine.Current.Direction == 2)
            {
                currentRoutine.Current.Column--;
                currentRoutine.Current.Direction = 3;
            }
            else if (currentRoutine.Current.Direction == 1)
            {
                currentRoutine.Current.Row--;
                currentRoutine.Current.Direction = 0;
            }
            else if (currentRoutine.Current.Direction == 0) currentRoutine.Current.Row--;
            else currentRoutine.Current.Column--;
        }
        public override string ToString()
        {
            return "NW";
        }
    }
}
