using ICM.WebSites.Application.Common.Interfaces;
using ICM.WebSites.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace ICM.WebSites.Infrastructure.Services;

public class TradingCentralClient : ITradingCentralClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<TradingCentralClient> _logger;

    public TradingCentralClient(HttpClient httpClient, ILogger<TradingCentralClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<string> GetAsync(DateOnly date, string culture, MarketSession marketSession)
    {
        var url = $"index_{culture}_{(culture == "ms" ? string.Empty : $"{marketSession}_")}{date.ToString("yyyyMMdd")}.html";

        _logger.LogInformation("Getting Trading Central content from '{Url}'", $"{_httpClient.BaseAddress}{url}");
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}