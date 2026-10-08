using Microsoft.Extensions.DependencyInjection;


public static class ApplicationDependency {
public static IServiceCollection AddApplicationDependency(this IServiceCollection service)
{
    service.AddScoped<IZoneService,ZoneService>();
    
    return service;

}

}