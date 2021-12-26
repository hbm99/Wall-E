using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public abstract class Operator : Instruction
    {
        public abstract int OperandsCount { get; }
        public int[] operands;
        public Operator(Robot robot):base(robot) 
        {
            operands = new int[OperandsCount];
        }
        public abstract void Evaluate(params int[] values);
        public override void Run()
        {

            for (int i = 0; i < OperandsCount; i++)
                operands[i] = robot.RobotStack.Pop();
        }
    }
}
