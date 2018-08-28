using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Query.ViewModels;
using Vinitore.Domain.Query.Views;

namespace Vinitore.Query.Queries
{
    public interface IWineQuery
    {
        IQueryable<WineGridViewModel> GetWines();

        IQueryable<WineDetailsViewModel> GetWine(int id);
    }
}
