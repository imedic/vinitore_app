using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Infrastructure.DbModel
{
    [Table("analysis", Schema = "public")]
    public class AnalysisTb
    {
        public int Id { get; set; }
        public WineTb Wine { get; set; }
        public int WineId { get; set; }

        public BarrelTb Barrel{ get; set; }
        public int BarrelId { get; set; }
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
