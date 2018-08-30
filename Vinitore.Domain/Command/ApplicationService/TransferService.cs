using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.TransferManagment;
using Vinitore.Domain.Command.InfrastructureContracts;

namespace Vinitore.Domain.Command.ApplicationService
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IBarrelRepository _barrelRepository;
        public TransferService(
            ITransferRepository transferRepository,
            IBarrelRepository barrelRepository
        )
        {
            _transferRepository = transferRepository;
            _barrelRepository = barrelRepository;
        }
        public void AddTransfer(TransferCommand command)
        {
            var barrelFrom = _barrelRepository.GetById(command.BarrelFromId);
            var barrelTo = _barrelRepository.GetById(command.BarrelToId);

            var transfer = new Transfer(command);

            if ((barrelFrom.CurrentCapacity >= command.Amount) && 
                (barrelTo.Capacity >= barrelTo.CurrentCapacity + command.Amount))
            {
                barrelFrom.RemoveAmount(command.Amount);
                barrelTo.AddAmount(command.Amount);
            }
            else
            {
                throw new Exception("Specified amount can't fit into the barrels");
            }

            using (var scope = new TransactionScope())
            {
                _barrelRepository.UpdateBarrel(command.BarrelFromId, barrelFrom);
                _barrelRepository.UpdateBarrel(command.BarrelToId, barrelTo);
                _transferRepository.AddTransfer(transfer);

                scope.Complete();
            }
        }
    }
}
