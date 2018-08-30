using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Command.DomainModels.TransferManagment
{
    public class Transfer
    {
        public int BarrelFromId { get; set; }
        public int BarrelToId { get; set; }
        public int WineId{ get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public Transfer()
        {

        }

        public Transfer(TransferCommand command)
        {
            SetProperties(command);
        }

        private void SetProperties(TransferCommand command)
        {
            if (command.BarrelFromId == command.BarrelToId)
            {
                throw new Exception("Can't transfer wine into the same barrel");
            }

            BarrelFromId = command.BarrelFromId;
            BarrelToId = command.BarrelToId;
            WineId = command.WineId;
            Amount = command.Amount;
            Date = DateTime.UtcNow;
        }
    }
}
