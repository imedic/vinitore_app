using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;

namespace Vinitore.Domain.Query.ViewModels
{
    public class BarrelView
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
        public string WineName { get; set; }
        public BarrelType Type { get; set; }
    }
}
