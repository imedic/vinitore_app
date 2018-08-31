using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Command.DomainModels.AnalyisisManagment
{
    public class Analysis
    {
        public Wine Wine { get; set; }
        public Barrel Barrel { get; set; }
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
