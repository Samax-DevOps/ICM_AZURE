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

    public Task<MarketNewsVm> Handle(GetMarketNewsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}