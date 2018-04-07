using Sample.NetCoreNorhwind.Entities;
using Sample.NetCoreNorthwind.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sample.NetCoreNorthwind.Service
{
    public class CategoryService
    {
        public CategoryRepository Repository { get; set; }
        public CategoryService(CategoryRepository repository)
        {
            Repository = repository;
        }

        public List<Category> OrderedCategories() => Repository.Get().OrderBy(x => x.Name).ToList();
    }
}
