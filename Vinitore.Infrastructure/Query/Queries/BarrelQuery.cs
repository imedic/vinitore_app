using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Query.Queries;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.Infrastructure.Query.Queries
{
    public class BarrelQuery : IBarrelQuery
    {
        private readonly QueryContext _context;

        public BarrelQuery(
            QueryContext queryContext     
        )
        {
            _context = queryContext;
        }

        public IQueryable<BarrelView> GetBarrels()
        {
            var query = _context.Barrels.ProjectTo<BarrelView>();

            return query;
        }

        public IQueryable<BarrelDetailsView> GetBarrel(int id)
        {
            var query = _context.Barrels.Where(y => y.Id == id).ProjectTo<BarrelDetailsView>();

            return query;
        }
    }
}
