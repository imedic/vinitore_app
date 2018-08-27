using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Infrastructure.Query;
using Winitore.Domain.Core.Query.Views;
using Winitore.Wine.Core.Query.Queries;

namespace Vinitore.Infrastructure.Queries
{
    public class WineQuery : IWineQuery
    {
        //private readonly QueryContext _queryContext;

        //public WineQuery(QueryContext queryContext)
        //{
        //    _queryContext = queryContext;
        //}

        public IQueryable<WineGridViewModel> GetWines()
        {
            throw new Exception("Reka sam ne može");
        }
    }
}
