using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    abstract class BinaryOperators : Operator
    {
        public override int OperandsCount { get { return 2; } }
        public BinaryOperators(Robot robot) : base(robot) 
        {
        }
    }
}
