using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;

namespace Vinitore.Domain.Command.ApplicationService.Contracts
{
    public interface IBarrelService
    {
        void AddBarrel(BarrelCommand command);

        void UpdateBarrel(int id, BarrelCommand command);

        void DeleteBarrel(int id);
    }
}
