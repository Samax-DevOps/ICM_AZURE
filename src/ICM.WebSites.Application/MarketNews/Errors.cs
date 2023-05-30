using ErrorOr;

namespace ICM.WebSites.Application.MarketNews;

public static partial class Errors
{
    public static class TradingCentral
    {
        public static Error ContentNotFoundError => Error.Failure(
            code: "TradingCentral.ContentNotFound",
            description: "TradingCentral content not found or not ready.");

        public static Error ParseError => Error.Unexpected(
            code: "TradingCentral.ParseError",
            description: "Failed to parse TradingCentral content.");
    }
}