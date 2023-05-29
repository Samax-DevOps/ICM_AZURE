using ICM.WebSites.Application.Common.Interfaces;
using ICM.WebSites.Domain.Enums;
using MediatR;

namespace ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;

public class GetMarketNewsQuery : IRequest<MarketNewsVm>
{
    public required DateOnly Date { get; init; }
    public required PartsOfDay PartOfDay { get; init; }
    public required string Culture { get; init; }
}

public class GetMarketNewsQueryHandler : IRequestHandler<GetMarketNewsQuery, MarketNewsVm>
{
    private ITradingCentralClient _tradingCentralClient;

    public GetMarketNewsQueryHandler(ITradingCentralClient tradingCentralClient)
    {
        _tradingCentralClient = tradingCentralClient;
    }

    public async Task<MarketNewsVm> Handle(GetMarketNewsQuery request, CancellationToken cancellationToken)
    {
        var url = CreateUrl(request);
        var html = await _tradingCentralClient.GetAsync(url);
        
        throw new NotImplementedException();
    }

    private string CreateUrl(GetMarketNewsQuery request)
    {
        return "index_en_morning_20230515.html";
    }
}