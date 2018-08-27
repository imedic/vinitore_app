using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Infrastructure.DbModel.Context
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.Migrate();
        }

        public DbSet<WineTb> Wines { get; set; }
        public DbSet<BarrelTb> Barrels { get; set; }
    }
}
