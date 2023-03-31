using Fwks.FwksApp.Application;
using Fwks.FwksApp.Core.Settings;
using Fwks.FwksApp.Infra.Mongo;
using Fwks.FwksApp.Infra.Postgres;
using Microsoft.Extensions.DependencyInjection;

namespace Fwks.FwksApp.App.Api.Configuration;

internal static class DependenciesConfiguration
{
    internal static IServiceCollection AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
        return services
            .AddApplicationServices()
            .AddMongoDb(appSettings)
            .AddPostgres(appSettings);
    }
}