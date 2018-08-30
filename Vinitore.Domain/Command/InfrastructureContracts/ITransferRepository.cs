using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.TransferManagment;

namespace Vinitore.Domain.Command.InfrastructureContracts
{
    public interface ITransferRepository
    {
        void AddTransfer(Transfer transfer);
    }
}
