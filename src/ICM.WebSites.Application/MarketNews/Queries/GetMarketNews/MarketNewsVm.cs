namespace ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;

public class MarketNewsVm
{
    public MarketNewsVm(string contentHtml, string termsAndConditionsHtml)
    {
        ContentHtml = contentHtml;
        TermsAndConditionsHtml = termsAndConditionsHtml;
    }

    public string ContentHtml { get; init; }
    public string TermsAndConditionsHtml { get; init; }
}