using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Query.ViewModels
{
    public class AnalysisView
    {
        public int Id { get; set; }

        public int WineId { get; set; }
        public string WineName { get; set; }

        public int BarrelId { get; set; }
        public string BarrelName { get; set; }

        public DateTime Date { get; set; }
    }
}
