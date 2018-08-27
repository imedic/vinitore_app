using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Infrastructure.Queries;
using Winitore.Wine.Core.Query.Queries;

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
