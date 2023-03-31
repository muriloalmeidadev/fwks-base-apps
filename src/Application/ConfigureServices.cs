using Fwks.Core;
using Fwks.FwksApp.Application.Services;
using Fwks.FwksApp.Core.Abstractions.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fwks.FwksApp.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services
            .AddScoped<ICustomerService, CustomerService>()
            .AddNotificationContext();
    }
}