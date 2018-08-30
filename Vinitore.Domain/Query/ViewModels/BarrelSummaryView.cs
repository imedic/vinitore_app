using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Query.ViewModels
{
    public class BarrelSummaryView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
    }
}
