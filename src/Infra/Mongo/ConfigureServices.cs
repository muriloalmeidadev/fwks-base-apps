using System;
using Fwks.FwksApp.Core.Abstractions.Repositories;
using Fwks.FwksApp.Core.Entities;
using Fwks.FwksApp.Core.Settings;
using Fwks.FwksApp.Infra.Mongo.Abstractions;
using Fwks.FwksApp.Infra.Mongo.Repositories;
using Fwks.MongoDb;
using Microsoft.Extensions.DependencyInjection;

namespace Fwks.FwksApp.Infra.Mongo;

public static class ConfigureServices
{
    public static IServiceCollection AddMongoDb(this IServiceCollection services, AppSettings appSettings)
    {
        return services
             .AddMongoDb<IEntityMap>(appSettings.Storage.MongoDb, appSettings.Storage.MongoDb.Database)
             .AddRepositories();
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services
            .AddScoped<ICustomerRepository<CustomerDocument, Guid>, CustomerRepository>();
    }
}