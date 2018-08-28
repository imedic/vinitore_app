using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Vinitore.Domain.AggregatesModel.BarrelAggregate;

namespace Vinitore.Infrastructure.DbModel
{
    [Table("barrel", Schema="public")]
    public class BarrelTb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WineTb Wine { get; set; }
        public int WineId { get; set; }
        public BarrelType Type { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
    }
}
