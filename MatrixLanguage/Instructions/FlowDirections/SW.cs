using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    class SW : Instruction
    {
        public override void Run()
        {
            if (!currentRoutine.IsInside(currentRoutine.Current.Row + 1, currentRoutine.Current.Column - 1))
                throw new ArgumentException("Out of bounds");
            if (currentRoutine.Current.Direction == 0)
            {
                currentRoutine.Current.Column--;
                currentRoutine.Current.Direction = 3;
            }
            else if (currentRoutine.Current.Direction == 1)
            {
                currentRoutine.Current.Row++;
                currentRoutine.Current.Direction = 2;
            }
            else throw new ArgumentException("Invalid Direction");
        }
    }
}
