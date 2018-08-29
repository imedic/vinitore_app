using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.TransferManagment;

namespace Vinitore.Domain.Query.ViewModels
{
    public class BarrelDetailsView
    {
        public string Name { get; set; }
        public BarrelType Type { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
        public string WineName { get; set; }
        public int WineId { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
    }
}
