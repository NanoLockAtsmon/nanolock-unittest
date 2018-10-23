using Nanolock_Unit_Testing_System.Test_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanolock_Unit_Testing_System
{
    class Test
    {
        private string TestID { get; set; }
        private string FileName { get; set; }
        public Registers Regs { get; set; }
        public Categories Cats { get; set; }
        public Variables Vars { get; set; }
        public List<Instruction> Flow { get; set; }

        public Test(string filename)
        {

        }

        public void Run()
        {
            foreach (Instruction ins in Flow)
            {
                ins.Run();
            }
        }
    }
}
