using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Winitore.Domain.Core.Query.Views;

namespace Winitore.Wine.Core.Query.Queries
{
    public interface IWineQuery
    {
        IQueryable<WineGridViewModel> GetWines();
    }
}
