using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;

namespace Vinitore.Domain.Command.InfrastructureContracts
{
    public interface IBarrelRepository
    {
        void AddBarrel(Barrel barrel);
        Barrel GetById(int id);
        void UpdateBarrel(int id, Barrel barrel);
        void DeleteBarrel(int id);
    }
}
