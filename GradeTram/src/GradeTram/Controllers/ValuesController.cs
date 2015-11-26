using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Raven.Client.Document;
using GradeTram.Contracts.Documents;
//using GradeTram.Contracts.Documents;

namespace GradeTram.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using (var store = new DocumentStore()
            {
                Url = "http://localhost:54321",
                DefaultDatabase = "gradetram"
            }.Initialize())
            {
                var session = store.OpenSession();
                session.Store(new Driver() { Name = "testowy ziomek", DriverIdentifier = 123, RegisterTime = DateTime.Now });
                session.SaveChanges();
                session.Dispose();
            }


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
