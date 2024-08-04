using System.Net;

namespace ICM.WebSites.Cms;

public static class Program
{
    public static void Main(string[] args)
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
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
                webBuilder.UseStartup<Startup>()
                    .UseKestrel(options => options.AddServerHeader = false);
            });
    }
}