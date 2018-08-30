using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.Domain.Query.Queries
{
    public interface IBarrelQuery
    {

        IQueryable<BarrelView> GetBarrels();

        IQueryable<BarrelDetailsView> GetBarrel(int id);

        IQueryable<BarrelSummaryView> GetBarrelsForTransfer(int wineId, int barrelId);
    }
}
