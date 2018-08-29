using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.InfrastructureContracts;

namespace Vinitore.Domain.Command.ApplicationService
{
    public class BarrelService : IBarrelService
    {
        private readonly IBarrelRepository _repository;
        public BarrelService(
                IBarrelRepository repository
        )
        {
            this._repository = repository;
        }

        public void AddBarrel(BarrelCommand command)
        {
            var barrel = new Barrel(command);

            _repository.AddBarrel(barrel);
        }

        public void DeleteBarrel(int id)
        {
            _repository.DeleteBarrel(id);
        }

        public void UpdateBarrel(int id, BarrelCommand command)
        {
            var barrel = _repository.GetById(id);

            barrel.Update(command);

            _repository.UpdateBarrel(id, barrel);
        }
    }
}
