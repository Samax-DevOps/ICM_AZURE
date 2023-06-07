using ICM.WebSites.Application.Common.Interfaces;
using ICM.WebSites.Domain.Enums;

namespace ICM.WebSites.Infrastructure.Services;

public class TradingCentralClient : ITradingCentralClient
{
    private readonly HttpClient _httpClient;

    public TradingCentralClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetAsync(DateOnly date, string culture, DayParts dayPart)
    {
        var url = $"index_{culture}_{(culture == "ms" ? string.Empty : $"{dayPart}_")}{date.ToString("yyyyMMdd")}.html";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}