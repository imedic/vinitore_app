using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Command.Commands
{
    public class AnalysisCommand
    {
        public int WineId { get; set; }
        public int BarrelId { get; set; }

        public double Alcohol { get; set; }
        public double Acid { get; set; }
        public double VolatileAcid { get; set; }
        public double TotalDryExtract { get; set; }
        public double TotalSulphurDioxide { get; set; }
        public double FreeSulphurDioxide { get; set; }
        public double PH { get; set; }
    }
}
