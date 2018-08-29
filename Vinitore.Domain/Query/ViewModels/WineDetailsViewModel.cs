using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Query.ViewModels
{
    public class WineDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public WineType Type { get; set; }
        public ICollection<BarrelView> Barrels { get; set; }
    }
}
