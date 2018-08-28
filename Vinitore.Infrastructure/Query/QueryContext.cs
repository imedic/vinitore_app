using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Infrastructure.Query
{
    public class QueryContext : VinitoreContext
    {
        public QueryContext(DbContextOptions<VinitoreContext> options)
        : base(options)
        {
        }

        public override int SaveChanges()
        {
            throw new InvalidOperationException("This context is read-only");
        }
    }
}
