using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.InfrastructureContracts;
using Vinitore.Infrastructure.DbModel;
using Vinitore.Infrastructure.DbModel.Context;

namespace Vinitore.Infrastructure.Command.Repositories
{
    class BarrelRepository : IBarrelRepository
    {
        private CommandContext _context;
        public BarrelRepository(
            CommandContext context)
        {
            _context = context;
        }

        public void AddBarrel(Barrel barrel)
        {
            var entry = Mapper.Map<BarrelTb>(barrel);
            _context.Barrels.Add(entry);
            _context.SaveChanges();
        }

        public Barrel GetById(int id)
        {
            var barrelTb = _context.Barrels.Where(x => x.Id == id).FirstOrDefault();

            var barrel = Mapper.Map<Barrel>(barrelTb);

            return barrel;
        }

        public void UpdateBarrel(int id, Barrel barrel)
        {
            var entry = _context.Barrels.SingleOrDefault(x => x.Id == id);

            entry.Capacity = barrel.Capacity;
            entry.CurrentCapacity = barrel.CurrentCapacity;
            entry.Name = barrel.Name;
            entry.Type = barrel.Type;
            entry.WineId = barrel.WineId;


            _context.Barrels.Update(entry);
            _context.SaveChanges();
        }

        public void DeleteBarrel(int id)
        {
            var itemToRemove = _context.Barrels.SingleOrDefault(x => x.Id == id);

            if (itemToRemove != null)
            {
                _context.Barrels.Remove(itemToRemove);
                _context.SaveChanges();
            }
        }
    }
}
