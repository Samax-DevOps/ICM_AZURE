namespace ICM.WebSites.Application.Common.Interfaces;

public interface ITradingCentralClient
{
    Task<string> GetAsync(string url);
}