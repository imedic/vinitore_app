using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vinitore.Infrastructure.DbModel.Context;
using Vinitore.Infrastructure.Queries;
using Vinitore.Query.Queries;

namespace Vinitore.Infrastructure
{
    public static class DomainIocModule
    {
        public static IServiceCollection AddLibrary(this IServiceCollection services)
        {
            services.AddScoped<IWineQuery, WineQuery>();
            services.AddDbContext<ApplicationContext>(options => options.UseNpgsql("User ID=vinitore;Password=vinitore;Host=localhost;Port=5432;Database=vinitore"));

            return services;
        }
    }
}
