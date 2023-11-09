using ICM.WebSites.Domain.Enums;

namespace ICM.WebSites.Application.Common.Interfaces;

public interface ITradingCentralClient
{
    Task<string> GetAsync(DateOnly date, string culture, MarketSession marketSession);
}