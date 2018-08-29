using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;

namespace Vinitore.Domain.Command.Commands
{
    public class BarrelCommand
    {
        public string Name { get; set; }
        public BarrelType Type { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
        public int WineId { get; set; }
    }
}
