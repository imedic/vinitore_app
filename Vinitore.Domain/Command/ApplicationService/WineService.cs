using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.WineManagment;
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

        public void AddWine(WineCommand command)
        {
            var wine = new Wine(command);
            _repository.AddWine(wine);
        }
    }
}
