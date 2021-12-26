using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.Registries
{
    class GetRegistry : Instruction
    {
        public char Name { get; set; }
        public GetRegistry(char name)
        {
            Name = name;
        }
        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries[Name]);
        }
    }
}
