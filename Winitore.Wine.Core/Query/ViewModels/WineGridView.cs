using System;
using System.Collections.Generic;
using System.Text;
using Winitore.Domain.Core.Enums;

namespace Winitore.Domain.Core.Query.Views
{
    public class WineGridViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public WineType Type { get; set; }
    }
}
