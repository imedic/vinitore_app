using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.Wine;
using Vinitore.Domain.Command.InfrastructureContracts;
using Vinitore.Infrastructure.DbModel;
using Vinitore.Infrastructure.DbModel.Context;
using Vinitore.Infrastructure.Query;

namespace Vinitore.Infrastructure.Repositories
{
    class WineRepository : IWineRepository
    {
        private CommandContext _context;
        public WineRepository(
            CommandContext context)
        {
            _context = context;
        }

        public void AddWine(Wine wine)
        {
            var entry = Mapper.Map<WineTb>(wine);
            _context.Wines.Add(entry);
            _context.SaveChanges();
        }
    }
}
