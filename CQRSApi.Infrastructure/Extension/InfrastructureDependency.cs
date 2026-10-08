using CQRSApi.Application.Contract.Common;
using CQRSApi.Application.Contract.Repositories;
using CQRSAPi.Infrastructure.Presistance;
using CQRSAPi.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSApi.Infrastructure.Extension;

public static class InfrastructureDependency
{
    public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
    {
        services.AddSingleton<IDbConnectionFactory,SqlConnectionFactory>();

        services.AddScoped<IZoneRepository,ZoneRepository>();
        return services;
    }
}