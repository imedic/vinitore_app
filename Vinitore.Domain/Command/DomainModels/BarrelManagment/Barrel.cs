using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;

namespace Vinitore.Domain.Command.DomainModels.BarrelManagment
{
    public class Barrel
    {
        public string Name { get; set; }
        public BarrelType Type { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
        public int WineId { get; set; }

        public Barrel()
        {

        }

        public Barrel(BarrelCommand command)
        {
            SetProperties(command);
        }

        public void Update(BarrelCommand command)
        {
            SetProperties(command);
        }

        public void AddAmount(int amount)
        {
            CurrentCapacity = CurrentCapacity + amount;
        }

        public void RemoveAmount(int amount)
        {
            CurrentCapacity = CurrentCapacity - amount;
        }

        private void SetProperties(BarrelCommand command)
        {
            if (string.IsNullOrEmpty(command.Name))
            {
                throw new Exception("Name cannot be empty");
            }

            Name = command.Name;
            Type = command.Type;
            Capacity = command.Capacity;
            CurrentCapacity = command.CurrentCapacity;
            WineId = command.WineId;
        }
    }
}
