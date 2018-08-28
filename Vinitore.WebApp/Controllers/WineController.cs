using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Query;
using Vinitore.Query.Queries;
using Vinitore.Domain.Command.DomainModels.WineManagment;
using Vinitore.Domain.Command.Commands;

namespace Vinitore.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineQuery _wineQuery;
        private IWineService _wineService;

        public WineController(
            IWineQuery wineQuery,
            IWineService wineService
        )
        {
            _wineQuery = wineQuery;
            _wineService = wineService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //var test = _wineQuery.GetWines();
            //return Ok(test.ToArray());

            return Ok("Evo ti vina");
        }

        [HttpGet("{id}", Name = "GetWine")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] WineCommand command)
        {
            _wineService.AddWine(command);

            return Ok("Saved!");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
