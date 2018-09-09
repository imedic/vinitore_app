using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Query.Queries;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.Infrastructure.Query.Queries
{
    public class AnalysisQuery : IAnalysisQuery
    {
        private readonly QueryContext _context;

        public AnalysisQuery(
            QueryContext context    
        )
        {
            _context = context;
        }

        public IQueryable<AnalysisView> GetAnalyses()
        {
            var query = _context.Analysis.ProjectTo<AnalysisView>();

            return query;
        }

        public IQueryable<AnalysisDetailView> GetAnalysis(int id)
        {
            var query = _context.Analysis.Where(y => y.Id == id).ProjectTo<AnalysisDetailView>();

            return query;
        }
    }
}
