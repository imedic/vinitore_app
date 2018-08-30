using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Query.Queries;

namespace Vinitore.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _service;
        private readonly ITransferQuery _query;

        public TransferController(
            ITransferService service,
            ITransferQuery query
        )
        {
            _service = service;
            _query = query;
        }

        [HttpGet("{id}", Name = "GetTransfers")]
        public IActionResult Get(int id)
        {
            var transfers = _query.GetTransfers(id);

            return Ok(transfers.ToArray());
        }

        [HttpPost]
        public IActionResult Post([FromBody] TransferCommand command)
        {
            _service.AddTransfer(command);
            return Ok();
        }
    }
}
