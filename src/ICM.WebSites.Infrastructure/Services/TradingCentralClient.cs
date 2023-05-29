using HtmlAgilityPack;
using ICM.WebSites.Application.Common.Interfaces;

namespace ICM.WebSites.Infrastructure.Services;

public class TradingCentralClient : ITradingCentralClient
{
    private readonly HttpClient _httpClient;

    public TradingCentralClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetAsync(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}