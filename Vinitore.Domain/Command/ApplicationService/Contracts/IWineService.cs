using Vinitore.Domain.Command.Commands;

namespace Vinitore.Domain.Command.ApplicationService.Contracts
{
    public interface IWineService
    {
        void AddWine(WineCommand command);
    }
}
