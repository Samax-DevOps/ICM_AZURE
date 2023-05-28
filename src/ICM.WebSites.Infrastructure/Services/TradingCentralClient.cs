using ICM.WebSites.Application.Common.Interfaces;

namespace ICM.WebSites.Infrastructure.Services;

public class TradingCentralClient : ITradingCentralClient
{
    private HttpClient _httpClient;

    public TradingCentralClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<string> GetAsync(string url)
    {
        throw new NotImplementedException();
    }
}