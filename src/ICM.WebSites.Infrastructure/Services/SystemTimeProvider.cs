using ICM.WebSites.Application.Common.Interfaces;

namespace ICM.WebSites.Infrastructure.Services;

public class SystemTimeProvider : ITimeProvider
{
    public DateTimeOffset GetUtcNow()
    {
        return DateTimeOffset.UtcNow;
    }
}