using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Command.DomainModels.AnalyisisManagment
{
    public class Analysis
    {
        public int WineId { get; set; }
        public int BarrelId { get; set; }
        public DateTime Date { get; set; }

        public double Alcohol { get; set; }
        public double Acid { get; set; }
        public double VolatileAcid { get; set; }
        public double TotalDryExtract { get; set; }
        public double TotalSulphurDioxide { get; set; }
        public double FreeSulphurDioxide { get; set; }
        public double PH { get; set; }

        public Analysis()
        {

        }

        public Analysis(AnalysisCommand command)
        {
            SetProperties(command);
        }

        private void SetProperties(AnalysisCommand command)
        {
            WineId = command.WineId;
            BarrelId = command.BarrelId;
            Date = DateTime.UtcNow;
            Alcohol = command.Alcohol;
            Acid = command.Acid;
            VolatileAcid = command.VolatileAcid;
            TotalDryExtract = command.TotalDryExtract;
            TotalSulphurDioxide = command.TotalSulphurDioxide;
            FreeSulphurDioxide = command.FreeSulphurDioxide;
            PH = command.PH;
        }
    }
}
