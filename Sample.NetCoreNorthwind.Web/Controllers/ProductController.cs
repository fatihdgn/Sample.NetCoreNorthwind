using Microsoft.AspNetCore.Mvc;
using Sample.NetCoreNorhwind.Entities;
using Sample.NetCoreNorthwind.Extensions;
using Sample.NetCoreNorthwind.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.NetCoreNorthwind.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        ProductService service;
        public ProductController(ProductService service)
        {
            this.service = service;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get() => service.OrderedProducts();

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(string id) => service.Repository.Get(id);

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Product value) => service.Repository.Add(value).With(x => service.Repository.Save());

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Product value) => service.Repository.Context.Attach(value.With(x => x.Id = id)).With(x => service.Repository.Save());

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id) => service.Repository.Remove(service.Repository.Get(id)).With(x => service.Repository.Save());
    }
}
