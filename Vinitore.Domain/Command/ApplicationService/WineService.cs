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

        public void UpdateWine(int id, WineCommand command)
        {
            // TODO: check if there are transfer records with current wine, and update it's name
            var wine = _repository.GetById(id);

            wine.Update(command);

            _repository.UpdateWine(id, wine);
        }

        public void DeleteWine(int id)
        {
            // TODO: check if there are transfer records with current wine, 
            //       put wineId to null, and put wineName to name
            _repository.DeleteWine(id);
        }
    }
}
