using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Domain.Query.Views
{
    public class WineGridViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public WineType Type { get; set; }
    }
}
