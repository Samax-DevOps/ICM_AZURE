using HtmlAgilityPack;
using ICM.WebSites.Application.Common.Interfaces;
using ICM.WebSites.Domain.Enums;
using MediatR;

namespace ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;

public record GetMarketNewsQuery : IRequest<MarketNewsVm>
{
    public required DateOnly Date { get; init; }
    public required PartsOfDay PartOfDay { get; init; }
    public required string Culture { get; init; }
}

public class GetMarketNewsQueryHandler : IRequestHandler<GetMarketNewsQuery, MarketNewsVm>
{
    private readonly ITradingCentralClient _tradingCentralClient;

    public GetMarketNewsQueryHandler(ITradingCentralClient tradingCentralClient)
    {
        _tradingCentralClient = tradingCentralClient;
    }

    public async Task<MarketNewsVm> Handle(GetMarketNewsQuery request, CancellationToken cancellationToken)
    {
        // load html from Trading Central
        var url = CreateUrl(request);
        var html = await _tradingCentralClient.GetAsync(url);

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);

        return new MarketNewsVm
        {
            TermsAndConditionsHtml = GetTermsAndConditionsHtml(htmlDoc),
            ContentHtml = GetContentHtml(htmlDoc),
            VideoHtml = GetVideoHtml(htmlDoc),
            NavigationHtml = GetNavigationHtml(htmlDoc)
        };
    }

    private static string GetContentHtml(HtmlDocument htmlDoc)
    {
        // get main content
        var contentNode = htmlDoc.GetElementbyId("MarketCommentPanel").Ancestors("table").First();

        // remove bottom border
        contentNode
            .Descendants("td")
            .Last(td => td.Attributes["style"]?.Value?.StartsWith("border-bottom") ?? false)
            .Attributes.Remove("style");
        
        return contentNode.OuterHtml;
    }

    private static string GetTermsAndConditionsHtml(HtmlDocument htmlDoc)
    {
        // get disclaimer and TC's
        var tcNode = htmlDoc.DocumentNode
            .SelectSingleNode("//td/b[starts-with(., 'TRADING CENTRAL Terms and conditions')]")
            .AncestorsAndSelf()
            .Skip(3)
            .First();

        // remove disclaimer row
        tcNode.SelectSingleNode("tr").Remove();
        
        return tcNode.OuterHtml;
    }

    private static string GetVideoHtml(HtmlDocument htmlDoc)
    {
        // get video
        var videoNode = htmlDoc.GetElementbyId("panelWebtv");
        
        return videoNode.OuterHtml;
    }

    private static string GetNavigationHtml(HtmlDocument htmlDoc)
    {
        // get navigation
        var navigationNode = htmlDoc.DocumentNode
            .SelectSingleNode("//comment()[contains(., 'navigation start')]/following-sibling::table");
        
        return navigationNode.OuterHtml;
    }

    private static string CreateUrl(GetMarketNewsQuery request)
    {
        return "index_en_morning_20230515.html";
    }
}