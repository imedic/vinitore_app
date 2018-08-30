using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinitore.Domain.Query.Queries;
using Vinitore.Domain.Query.ViewModels;

namespace Vinitore.Infrastructure.Query.Queries
{
    public class TransferQuery : ITransferQuery
    {
        private readonly QueryContext _context;

        public TransferQuery(
            QueryContext context
        )
        {
            _context = context;
        }

        public IQueryable<TransferView> GetTransfers(int barrelId)
        {
            var query = _context.Transfers.Where(y => y.BarrelFromId == barrelId || y.BarrelToId == barrelId).ProjectTo<TransferView>();

            return query;
        }
    }
}
