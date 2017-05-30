using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProxy.TestServer.Models;

namespace WebApiProxy.TestServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<ItemTestViewModel> Get()
        {
            yield return new ItemTestViewModel { Name = "One", Value = 1 };
            yield return new ItemTestViewModel { Name = "Two", Value = 2 };
            yield return new ItemTestViewModel { Name = "Three", Value = 3 };
        }

        // GET api/values/5
        public ItemTestViewModel Get(int id)
        {
            return Get().FirstOrDefault(i => i.Value == id);
        }

        // POST api/values
        public void Post([FromBody]ItemTestViewModel value)
        {
        }
    }
}
