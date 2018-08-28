using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Command.InfrastructureContracts
{
    public interface IWineRepository
    {
        void AddWine(Wine wine);
    }
}
