namespace ICM.WebSites.Application.Common.Interfaces;

public interface ITimeProvider
{
    DateTimeOffset GetUtcNow();
}