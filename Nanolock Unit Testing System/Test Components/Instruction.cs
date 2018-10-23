using System;

namespace Nanolock_Unit_Testing_System.Test_Components
{
    public abstract class Instruction
    {
        public Registers Regs { get; set; }
        public int LineNumber { get; set; }
        
        public abstract void Run();
        public abstract void Error();
    }
}