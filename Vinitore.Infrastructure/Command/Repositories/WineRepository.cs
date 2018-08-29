using AutoMapper;
using System.Linq;
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

        public Wine GetById(int id)
        {
            var wineTb = _context.Wines.Where(x => x.Id == id).FirstOrDefault();

            var wine = Mapper.Map<Wine>(wineTb);

            return wine;
        }

        public void UpdateWine(int id, Wine wine)
        {
            var entry = _context.Wines.SingleOrDefault(x => x.Id == id);

            entry.Name = wine.Name;
            entry.Type = wine.Type;
            entry.Year = wine.Year;

            _context.Wines.Update(entry);
            _context.SaveChanges();
        }

        public void DeleteWine(int id)
        {
            var itemToRemove = _context.Wines.SingleOrDefault(x => x.Id == id);

            if (itemToRemove != null)
            {
                _context.Wines.Remove(itemToRemove);
                _context.SaveChanges();
            }
        }
    }
}
