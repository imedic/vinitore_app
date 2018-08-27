using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Winitore.Wine.Core.Query;
using Winitore.Wine.Core.Query.Queries;

namespace Vinitore.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineQuery _wineQuery;

        public WineController(
            IWineQuery wineQuery
        )
        {
            _wineQuery = wineQuery;
        }
        // GET: api/Wine
        [HttpGet]
        public IActionResult Get()
        {
            var test = _wineQuery.GetWines();
            return Ok(test.ToArray());
        }

        // GET: api/Wine/5
        [HttpGet("{id}", Name = "GetWine")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Wine
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Wine/5
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
