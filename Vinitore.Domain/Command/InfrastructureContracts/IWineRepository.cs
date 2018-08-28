using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Command.InfrastructureContracts
{
    public interface IWineRepository
    {
        void AddWine(Wine wine);

        void UpdateWine(int id, Wine command);

        void DeleteWine(int id);

        Wine GetById(int id);
    }
}
