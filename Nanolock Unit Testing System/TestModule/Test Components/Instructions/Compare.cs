using Nanolock_Unit_Testing_System.TestModule.Test_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanolock_Unit_Testing_System.Test_Components.Instructions
{
    class Compare<T> : Instruction
    {
        private T var1;
        private T var2;

        public Compare(T var1, T var2){
            try
            {
                this.var1 = var1;
                this.var2 = var2;
            }
            catch
            {
                Error(ErrorType.Init);
            }
        }

        public override void Run()
        {
            try
            {
                switch (Type.GetTypeCode(var1.GetType()))
                {
                    case TypeCode.Int32:
                        Regs.CompareResult = (int)(object)var1 == (int)(object)var2;
                        break;
                    case TypeCode.Double:
                        Regs.CompareResult = (double)(object)var1 == (double)(object)var2;
                        break;
                    case TypeCode.String:
                        Regs.CompareResult = (string)(object)var1 == (string)(object)var2;
                        break;
                    default:
                        Regs.CompareResult = (object)var1 == (object)var2;
                        break;
                }
            }
            catch
            {
                Error(ErrorType.RunTime);
            }
        }

        public override void Error(ErrorType error)
        {
            switch (error)
            {
                case ErrorType.Init:
                    Console.WriteLine("Failed to initialize Compare on line: " + LineNumber);
                    break;
                case ErrorType.RunTime:
                    Console.WriteLine("Failed to execute Compare on line: " + LineNumber);
                    break;
                default:
                    Console.WriteLine("General Error in Compare Instruction on line: " + LineNumber);
                    break;
            }
        }
    }

}
