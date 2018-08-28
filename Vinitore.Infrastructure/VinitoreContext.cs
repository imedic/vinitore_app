using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Infrastructure.DbModel;
using Vinitore.Infrastructure.DbModel.Context;
using Vinitore.Infrastructure.Query;

namespace Vinitore.Infrastructure
{
    public class VinitoreContext : DbContext
    {
        public VinitoreContext(DbContextOptions<VinitoreContext> options)
        : base(options)
        {
        }

        public DbSet<WineTb> Wines { get; set; }
        public DbSet<BarrelTb> Barrels { get; set; }
    }
}
