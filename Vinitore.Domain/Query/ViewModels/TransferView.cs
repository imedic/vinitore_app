using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Domain.Query.ViewModels
{
    public class TransferView
    {
        public int BarrelFromId { get; set; }
        public string BarrelFromName { get; set; }

        public int BarrelToId { get; set; }
        public string BarrelToName { get; set; }

        public int WineId { get; set; }
        public string WineName { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }

    }
}
