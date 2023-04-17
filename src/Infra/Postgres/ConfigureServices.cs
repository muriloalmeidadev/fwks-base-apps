using Fwks.FwksApp.Core.Abstractions.Repositories;
using Fwks.FwksApp.Core.Entities;
using Fwks.FwksApp.Core.Settings;
using Fwks.FwksApp.Infra.Postgres.Contexts;
using Fwks.FwksApp.Infra.Postgres.Repositories;
using Fwks.Postgres;
using Microsoft.Extensions.DependencyInjection;

namespace Fwks.FwksApp.Infra.Postgres;

public static class ConfigureServices
{
    public static IServiceCollection AddPostgres(this IServiceCollection services, AppSettings appSettings)
    {
        return services
            .AddPostgres<AppServiceContext>(appSettings.Storage.Postgres)
            .AddRepositories();
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services
            .AddScoped<ICustomerRepository<CustomerEntity, int>, CustomerRepository>();
    }
}