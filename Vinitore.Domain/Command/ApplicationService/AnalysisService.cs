using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.AnalyisisManagment;
using Vinitore.Domain.Command.InfrastructureContracts;

namespace Vinitore.Domain.Command.ApplicationService
{
    public class AnalysisService : IAnalysisService
    {
        private readonly IAnalysisRepository _repository;

        public AnalysisService(
            IAnalysisRepository repository    
        )
        {
            _repository = repository;
        }

        public void AddAnalysis(AnalysisCommand command)
        {
            var analysis = new Analysis(command);

            _repository.AddAnalysis(analysis);
        }
    }
}
