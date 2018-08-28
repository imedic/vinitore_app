using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vinitore.Infrastructure.DbModel.Context
{
    public class CommandContext : VinitoreContext
    {
        public CommandContext(DbContextOptions<VinitoreContext> options)
        : base(options)
        {
        }
    }
}
