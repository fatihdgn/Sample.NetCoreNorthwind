using Sample.NetCoreNorhwind.Entities;
using Sample.NetCoreNorthwind.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Sample.NetCoreNorthwind.Service
{
    public class ProductService
    {
        public ProductRepository Repository { get; set; }
        public ProductService(ProductRepository repository)
        {
            Repository = repository;
        }

        public List<Product> OrderedProducts() => Repository.Get().OrderBy(x => x.Name).ToList();
    }
}
