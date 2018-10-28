using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OData.Client;
using NanoLockSec.Services.Storage.Abstractions;

namespace Nanolock_Unit_Testing_System.TestModule.Test_Components.Instructions.Http
{
    class StorageQuery<TEntity, TResult>
    {
        private Func<DataServiceQuery<TEntity>, IQueryable> queryBuilder;

        public StorageQuery(Func<DataServiceQuery<TEntity>, IQueryable> queryBuilder)
        {
            this.queryBuilder = queryBuilder;
        }

        public async Task<IEnumerable<TResult>> Execute()
        {
            //TODO: Get StorageClient service url
            StorageClient storage = new StorageClient("");
            return await storage.Query<TEntity, TResult>(queryBuilder);
        }
    }
}
