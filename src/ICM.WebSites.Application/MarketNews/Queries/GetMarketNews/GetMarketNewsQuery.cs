using System.Globalization;
using System.Text.RegularExpressions;
using ErrorOr;
using HtmlAgilityPack;
using ICM.WebSites.Application.Common.Interfaces;
using ICM.WebSites.Domain.Enums;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;

public record GetMarketNewsQuery : IRequest<ErrorOr<MarketNewsVm>>
{
    public required DateOnly Date { get; init; }
    public required PartsOfDay PartOfDay { get; init; }
    public required string Culture { get; init; }
}

public partial class GetMarketNewsQueryHandler : IRequestHandler<GetMarketNewsQuery, ErrorOr<MarketNewsVm>>
{
    [GeneratedRegex("not found")]
    private static partial Regex NotFoundRegex();

    private readonly ITradingCentralClient _tradingCentralClient;
    private readonly ILogger _logger;

    public GetMarketNewsQueryHandler(ITradingCentralClient tradingCentralClient, ILogger<GetMarketNewsQueryHandler> logger)
    {
        _tradingCentralClient = tradingCentralClient;
        _logger = logger;
    }

    public async Task<ErrorOr<MarketNewsVm>> Handle(GetMarketNewsQuery request, CancellationToken cancellationToken)
    {
        // load html from Trading Central
        var url = CreateUrl(request);
        var html = await _tradingCentralClient.GetAsync(url);

        if (NotFoundRegex().IsMatch(html))
        {
            return Errors.TradingCentral.ContentNotFoundError;
        }

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);

        try
        {
            var viewModel = new MarketNewsVm
            {
                TermsAndConditionsHtml = GetTermsAndConditionsHtml(htmlDoc),
                ContentHtml = GetContentHtml(htmlDoc),
                VideoHtml = GetVideoHtml(htmlDoc),
                NavigationHtml = GetNavigationHtml(htmlDoc)
            };

            return viewModel;
        }
        catch (Exception e)
        {
            _logger.LogError(e, Errors.TradingCentral.ParseError.ToString());
            return Errors.TradingCentral.ParseError;
        }
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
        var node = htmlDoc.DocumentNode
            .SelectSingleNode("//td/b[starts-with(., 'TRADING CENTRAL Terms and conditions')]")
            .AncestorsAndSelf()
            .Skip(3)
            .First();

        // remove disclaimer row
        node.SelectSingleNode("tr").Remove();

        return node.OuterHtml;
    }

    private static string? GetVideoHtml(HtmlDocument htmlDoc)
    {
        // get video
        var videoNode = htmlDoc.GetElementbyId("panelWebtv");

        return videoNode?.OuterHtml;
    }

    private static string GetNavigationHtml(HtmlDocument htmlDoc)
    {
        // get navigation
        var node = htmlDoc.DocumentNode
            .SelectSingleNode("//comment()[contains(., 'navigation start')]/following-sibling::table");

        return node.OuterHtml;
    }

    private static string CreateUrl(GetMarketNewsQuery request)
    {
        var culture = CultureInfo.GetCultureInfo(request.Culture).TwoLetterISOLanguageName;

        return $"index_{culture}_{request.PartOfDay}_{request.Date.ToString("yyyyMMdd")}.html";
    }
}