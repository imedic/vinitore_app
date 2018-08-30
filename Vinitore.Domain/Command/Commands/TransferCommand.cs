using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Command.Commands
{
    public class TransferCommand
    {
        public int BarrelFromId { get; set; }
        public int BarrelToId { get; set; }
        public int WineId { get; set; }
        public int Amount { get; set; }
    }
}
