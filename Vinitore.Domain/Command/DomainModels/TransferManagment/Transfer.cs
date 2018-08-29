using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Command.DomainModels.TransferManagment
{
    public class Transfer
    {
        public int FromBarelId { get; set; }
        public int ToBarrelId { get; set; }
        public int Amount { get; set; }
    }
}
