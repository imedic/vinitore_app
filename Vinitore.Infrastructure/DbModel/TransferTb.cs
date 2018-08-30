using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vinitore.Infrastructure.DbModel
{
    [Table("transfers", Schema = "public")]
    public class TransferTb
    {
        public int Id { get; set; }

        public WineTb Wine { get; set; }
        public int WineId { get; set; }

        public BarrelTb BarrelFrom { get; set; }
        public int BarrelFromId { get; set; }

        public BarrelTb BarrelTo { get; set; }
        public int BarrelToId { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
