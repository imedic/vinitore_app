using AutoMapper;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.WineManagment;
using Vinitore.Domain.Command.InfrastructureContracts;
using Vinitore.Infrastructure.DbModel;
using Vinitore.Infrastructure.DbModel.Context;

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
