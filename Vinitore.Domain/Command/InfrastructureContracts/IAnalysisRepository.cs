using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.AnalyisisManagment;

namespace Vinitore.Domain.Command.InfrastructureContracts
{
    public interface IAnalysisRepository
    {
        void AddAnalysis(Analysis analysis);
    }
}
