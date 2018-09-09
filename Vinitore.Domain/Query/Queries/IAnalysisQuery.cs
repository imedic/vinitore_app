using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.Domain.Query.Queries
{
    public interface IAnalysisQuery
    {
        IQueryable<AnalysisView> GetAnalyses();

        IQueryable<AnalysisDetailView> GetAnalysis(int id);
    }
}
