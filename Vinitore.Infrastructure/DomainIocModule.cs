using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.DependencyInjection;
using Vinitore.Domain.Command.ApplicationService;
using Vinitore.Domain.Command.ApplicationService.Contracts;
using Vinitore.Domain.Command.InfrastructureContracts;
using Vinitore.Infrastructure.DbModel.Context;
using Vinitore.Infrastructure.Queries;
using Vinitore.Infrastructure.Repositories;
using Vinitore.Query.Queries;

namespace Vinitore.Infrastructure
{
    public static class DomainIocModule
    {
        public static IServiceCollection AddLibrary(this IServiceCollection services)
        {
            services.AddScoped<IWineService, WineService>();
            services.AddScoped<IWineQuery, WineQuery>();
            services.AddScoped<IWineRepository, WineRepository>();

            services.AddDbContext<VinitoreContext>(options => options.UseNpgsql("User ID=vinitore;Password=vinitore;Host=localhost;Port=5432;Database=vinitore"));
            services.AddDbContext<CommandContext>(options => options.UseNpgsql("User ID=vinitore;Password=vinitore;Host=localhost;Port=5432;Database=vinitore"));
            services.AddDbContext<Query.QueryContext>(options => options.UseNpgsql("User ID=vinitore;Password=vinitore;Host=localhost;Port=5432;Database=vinitore"));

            return services;
        }
    }
}
