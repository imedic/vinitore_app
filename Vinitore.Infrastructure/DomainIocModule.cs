using Microsoft.Extensions.DependencyInjection;
using Vinitore.Infrastructure.Queries;
using Vinitore.Query.Queries;

namespace Vinitore.Infrastructure
{
    public static class DomainIocModule
    {
        public static IServiceCollection AddLibrary(this IServiceCollection services)
        {
            services.AddScoped<IWineQuery, WineQuery>();

            return services;
        }
    }
}
