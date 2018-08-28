using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.Wine;

namespace Vinitore.Domain.Command.ApplicationService.Contracts
{
    public interface IWineService
    {
        void AddWine(Wine command);
    }
}
