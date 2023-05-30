using Microsoft.Extensions.DependencyInjection;

namespace ICM.WebSites.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediator();

        return services;
    }
}