using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Infrastructure.Query;
using Vinitore.Domain.Query.Views;
using Vinitore.Query.Queries;
using AutoMapper.QueryableExtensions;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.Infrastructure.Queries
{
    public class WineQuery : IWineQuery
    {
        private readonly QueryContext _queryContext;

        public WineQuery(QueryContext queryContext)
        {
            _queryContext = queryContext;
        }

        public IQueryable<WineGridViewModel> GetWines()
        {
            var query = _queryContext.Wines.ProjectTo<WineGridViewModel>();

            return query;
        }

        public IQueryable<WineDetailsViewModel> GetWine(int id)
        {
            var query = _queryContext.Wines.Where(x => x.Id == id).ProjectTo<WineDetailsViewModel>();

            return query;
        }
    }
}
