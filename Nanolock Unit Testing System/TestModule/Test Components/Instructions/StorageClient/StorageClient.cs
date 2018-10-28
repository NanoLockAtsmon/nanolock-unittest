using Microsoft.OData.Client;
using Nanolock_Unit_Testing_System.TestModule.Test_Components;
using Nanolock_Unit_Testing_System.TestModule.Test_Components.Instructions.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanolock_Unit_Testing_System.Test_Components.Instructions
{
    //TResult should be replaced when we understand better what it should be
    class StorageClient<TEntity, TResult> : Instruction
    {
        private StorageQuery<TEntity, TResult> query;

        public StorageClient(Registers r, Func<DataServiceQuery<TEntity>, IQueryable> queryBuilder)
        {
            try
            {
                query = new StorageQuery<TEntity, TResult>(queryBuilder);
                Regs = r;
            }
            catch
            {
                Error(ErrorType.Init);
            }
        }


        public override async void Run()
        {
            try
            {
                Regs.Response = await query.Execute();
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
                    Console.WriteLine("Failed to initialize Storage Query on line: " + LineNumber);
                    break;
                case ErrorType.RunTime:
                    Console.WriteLine("Failed to execute Storage Query on line: " + LineNumber);
                    break;
                default:
                    Console.WriteLine("General Error in Storage Query on line: " + LineNumber);
                    break;
            }
        }
    }
}
