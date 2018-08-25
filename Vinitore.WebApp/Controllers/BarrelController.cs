using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vinitore.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarrelController : ControllerBase
    {
        // GET: api/Barrel
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Barrel/5
        [HttpGet("{id}", Name = "GetBarrel")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Barrel
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Barrel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
