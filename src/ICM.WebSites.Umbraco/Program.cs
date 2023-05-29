using ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;
using ICM.WebSites.Domain.Enums;

namespace ICM.WebSites.Umbraco;

public static class Program
{
    public static void Main(string[] args)
    {
        var c = new GetMarketNewsQuery {Date = default, PartOfDay = PartsOfDay.Morning, Culture = "null"};
        
        CreateHostBuilder(args)
            .Build()
            .Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureUmbracoDefaults()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStaticWebAssets();
                webBuilder.UseStartup<Startup>();
            });
    }
}