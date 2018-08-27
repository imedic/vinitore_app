using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Enums;

namespace Vinitore.Domain.Query.Views
{
    public class WineGridViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public WineType Type { get; set; }
    }
}
