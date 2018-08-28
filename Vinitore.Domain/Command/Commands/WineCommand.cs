using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.AnalyisisManagment;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Command.Commands
{
    public class WineCommand
    {
        public string Name { get; set; }
        public WineType Type { get; set; }
        public int Year { get; set; }
        public ICollection<Barrel> Barrels { get; set; }
        //public ICollection<Analysis> Analysis { get; set; }
    }
}
