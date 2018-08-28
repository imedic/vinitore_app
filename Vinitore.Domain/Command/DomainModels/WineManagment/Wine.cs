using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.AnalyisisManagment;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;

namespace Vinitore.Domain.Command.DomainModels.WineManagment
{
    public class Wine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public WineType Type { get; set; }

        public ICollection<Barrel> Barrels { get; set; }
        //public ICollection<Analysis> Analysis { get; set; }

        public Wine()
        {

        }

        public Wine(WineCommand command)
        {
            SetProperties(command);
        }

        private void SetProperties(WineCommand command)
        {
            if (string.IsNullOrEmpty(command.Name))
            {
                throw new Exception("Name cannot be empty");
            }

            Name = command.Name;
            Year = command.Year;
            Type = command.Type;
            Barrels = command.Barrels ?? new List<Barrel>();
            //Analysis = command.Analysis ?? new List<Analysis>();
        }
    }
}
