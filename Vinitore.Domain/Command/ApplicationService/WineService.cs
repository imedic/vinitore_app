using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.Wine;
using Vinitore.Domain.Command.InfrastructureContracts;

namespace Vinitore.Domain.Command.ApplicationService
{
    public class WineService : IWineService
    {
        private IWineRepository _repository;

        public WineService(
            IWineRepository repository    
        )
        {
            _repository = repository;
        }

        public void AddWine(Wine command)
        {
            _repository.AddWine(command);
        }
    }
}
