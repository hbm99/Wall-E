using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.FlowDirections
{
    class TN : Instruction
    {
        public override void Run()
        {
            if (!currentRoutine.IsInside(currentRoutine.Current.Row - 1, currentRoutine.Current.Column + 1)) 
                throw new ArgumentException("Out of bounds");
            if (currentRoutine.Current.Direction == 1 || currentRoutine.Current.Direction == 3) 
            {
                currentRoutine.Current.Row--;
                currentRoutine.Current.Direction = 0;
            }
            else if (currentRoutine.Current.Direction == 2)
            {
                currentRoutine.Current.Column++;
                currentRoutine.Current.Direction = 1;
            }
            else throw new ArgumentException("Invalid Direction");
        }
    }
}
