using Sample.NetCoreNorhwind.Entities;
using Sample.NetCoreNorthwind.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.NetCoreNorthwind.Repositories
{
    public class NorthwindRepository<TEntity> : Repository<NorthwindDB, TEntity>
        where TEntity : Entity
    {
        public NorthwindRepository(NorthwindDB context) : base(context)
        {
        }
    }
}
