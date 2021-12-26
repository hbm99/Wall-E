using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage.Instructions.Registries.Set
{
    class SetRegistry : Instruction
    {
        public char Name { get; set; }
        public SetRegistry(char name)
        {
            Name = name;
        }
        public override void Run()
        {
            currentRoutine.Registries[Name] = robot.RobotStack.Pop();
        }
    }
}
