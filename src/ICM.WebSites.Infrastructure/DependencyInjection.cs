using ICM.WebSites.Application.Common.Interfaces;
using ICM.WebSites.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ICM.WebSites.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddHttpClient<TradingCentralClient>(client =>
        {
            client.BaseAddress = new Uri("https://newsletters.tradingcentral.com/icmcapital/");
        });

        services.AddTransient<ITradingCentralClient>(c => c.GetRequiredService<TradingCentralClient>());
        services.AddSingleton<IDateTimeProvider, SystemDateTimeProvider>();
        
        return services;
    }
}