using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Query.Queries;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarrelController : ControllerBase
    {
        private readonly IBarrelService _barrelService;
        private readonly IBarrelQuery _barrelQuery;

        public BarrelController(
            IBarrelService barrelService,
            IBarrelQuery barrelQuery
        )
        {
            _barrelService = barrelService;
            _barrelQuery = barrelQuery;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var barrels = _barrelQuery.GetBarrels();

            return Ok(barrels.ToArray());
        }

        [HttpGet("{id}", Name = "GetBarrel")]
        public IActionResult Get(int id)
        {
            var barrel = _barrelQuery.GetBarrel(id);

            return Ok(barrel.FirstOrDefault());
        }

        [HttpGet("transfer-barrels", Name = "GetTransferBarrels")]
        public IActionResult GetBarrelsWithSameWine([FromQuery] int barrelId, [FromQuery] int wineId)
        {
            var barrels = _barrelQuery.GetBarrelsForTransfer(wineId, barrelId);

            return Ok(barrels.ToArray());
        }

        [HttpPost]
        public IActionResult Post([FromBody] BarrelCommand command)
        {
            _barrelService.AddBarrel(command);

            return Ok();
        }

        // PUT: api/Barrel/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BarrelCommand command)
        {
            _barrelService.UpdateBarrel(id, command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _barrelService.DeleteBarrel(id);

            return Ok();
        }
    }
}
