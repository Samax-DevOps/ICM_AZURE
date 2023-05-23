using ICM.WebSites.Domain.Enums;
using MediatR;

namespace ICM.WebSites.Application.MarketNews.Queries.GetMarketNews;

public class GetMarketNewsQuery : IRequest<MarketNewsVm>
{
    public DateOnly Date { get; init; }
    public DayParts DayPart { get; init; }
    public string Culture { get; init; } = null!;
}
