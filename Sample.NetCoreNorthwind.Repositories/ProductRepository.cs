using Sample.NetCoreNorhwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Sample.NetCoreNorthwind.Context;

namespace Sample.NetCoreNorthwind.Repositories
{
    public class ProductRepository : NorthwindRepository<Product>
    {
        public ProductRepository(NorthwindDB context) : base(context)
        {
        }
    }
}
