using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.NetCoreNorthwind.Service;
using Sample.NetCoreNorhwind.Entities;
using Sample.NetCoreNorthwind.Extensions;

namespace Sample.NetCoreNorthwind.Web.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        CategoryService service;
        public CategoryController(CategoryService service)
        {
            this.service = service;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Category> Get() => service.OrderedCategories();

        // GET api/values/5
        [HttpGet("{id}")]
        public Category Get(string id) => service.Repository.Get(id);

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Category value) => service.Repository.Add(value).With(x => service.Repository.Save());

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Category value) => service.Repository.Context.Attach(value.With(x => x.Id = id)).With(x => service.Repository.Save());

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id) => service.Repository.Remove(service.Repository.Get(id)).With(x => service.Repository.Save());

    }
}
