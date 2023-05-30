namespace ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;

public class MarketNewsVm
{
    public required string ContentHtml { get; init; }
    public required string TermsAndConditionsHtml { get; init; }
    public required string? VideoHtml { get; init; }
    public required string NavigationHtml { get; init; }
}

