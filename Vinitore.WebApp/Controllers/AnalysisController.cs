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
    public class AnalysisController : ControllerBase
    {
        private readonly IAnalysisService _sevice;
        private readonly IAnalysisQuery _query;

        public AnalysisController(
            IAnalysisService service,
            IAnalysisQuery query
        )
        {
            _sevice = service;
            _query = query;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var analyses = _query.GetAnalyses();

            return Ok(analyses.ToArray());
        }


        [HttpGet("{id}", Name = "GetAnalysis")]
        public IActionResult Get(int id)
        {
            var analysis = _query.GetAnalysis(id);

            return Ok(analysis.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Post([FromBody] AnalysisCommand command)
        {
            _sevice.AddAnalysis(command);

            return Ok();
        }
    }
}
