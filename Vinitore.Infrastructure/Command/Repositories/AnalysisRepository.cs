using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.AnalyisisManagment;
using Vinitore.Domain.Command.InfrastructureContracts;
using Vinitore.Infrastructure.DbModel;
using Vinitore.Infrastructure.DbModel.Context;

namespace Vinitore.Infrastructure.Command.Repositories
{
    public class AnalysisRepository : IAnalysisRepository
    {
        private readonly CommandContext _context;

        public AnalysisRepository(
            CommandContext context    
        )
        {
            _context = context;
        }

        public void AddAnalysis(Analysis analysis)
        {
            var record = Mapper.Map<AnalysisTb>(analysis);

            _context.Analysis.Add(record);
            _context.SaveChanges();
        }
    }
}
