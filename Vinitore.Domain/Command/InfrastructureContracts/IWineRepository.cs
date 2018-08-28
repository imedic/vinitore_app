using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.Wine;

namespace Vinitore.Domain.Command.InfrastructureContracts
{
    public interface IWineRepository
    {
        void AddWine(Wine wine);
    }
}
