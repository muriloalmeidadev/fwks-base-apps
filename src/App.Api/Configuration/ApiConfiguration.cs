using FluentValidation;
using FluentValidation.AspNetCore;
using Fwks.AspNetCore.Conventions;
using Fwks.AspNetCore.Extensions;
using Fwks.AspNetCore.Filters.ActionFilters;
using Fwks.AspNetCore.Filters.ExceptionFilters;
using Fwks.AspNetCore.Filters.ResultFilters;
using Fwks.FwksApp.App.Api.Configuration.ExceptionHandlers;
using Fwks.FwksApp.Core.Configuration;
using Fwks.FwksApp.Core.Exceptions;
using Fwks.FwksApp.Core.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Fwks.FwksApp.App.Api.Configuration;

internal static class ApiConfiguration
{
    internal static IServiceCollection AddApiConfiguration(this IServiceCollection services)
    {
        return services
            .AddHttpClient()
            .AddDefaultResponseCompression()
            .AddDefaultVersioning()
            .AddFluentValidation()
            .AddExceptionHandlers()
            .AddControllersConfiguration();
    }

    private static IServiceCollection AddFluentValidation(this IServiceCollection services)
    {
        return services
            .AddFluentValidationAutoValidation()
            .AddValidatorsFromAssembly(typeof(CustomerResponse).Assembly)
            .Configure<ApiBehaviorOptions>(x => x.SuppressModelStateInvalidFilter = true);
    }

    private static IServiceCollection AddControllersConfiguration(this IServiceCollection services)
    {
        return services
            .AddControllers(x =>
            {
                x.AddJsonAsDefaultMediaType();

                x.AddApplicationNotificationResponses(StatusCodes.Status500InternalServerError, StatusCodes.Status401Unauthorized);

                x.Filters.Add<RequestValidationActionFilter>();
                x.Filters.Add<ExceptionHandlerFilter>();
                x.Filters.Add<NotificationResultFilter>();

                x.Conventions.Add(new SlugCaseRouteTransformerConvention());
            })
            .AddJsonOptions(x => JsonSerializerConfiguration.Configure(x.JsonSerializerOptions))
            .Services;
    }

    private static IServiceCollection AddExceptionHandlers(this IServiceCollection services)
    {
        return services
            .AddDefaultExceptionHandlers()
            .AddExceptionHandler<CustomException, CustomExceptionHandler>();
    }
}
