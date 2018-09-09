using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Query.ViewModels
{
    public class AnalysisDetailView
    {
        public int Id { get; set; }

        public int WineId { get; set; }
        public string WineName { get; set; }

        public int BarrelId { get; set; }
        public string BarrelName { get; set; }

        public DateTime Date { get; set; }

        public double Alcohol { get; set; }
        public double Acid { get; set; }
        public double VolatileAcid { get; set; }
        public double TotalDryExtract { get; set; }
        public double TotalSulphurDioxide { get; set; }
        public double FreeSulphurDioxide { get; set; }
        public double PH { get; set; }
    }
}
