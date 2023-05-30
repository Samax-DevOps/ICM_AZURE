namespace ICM.WebSites.Application.Common.Interfaces;

public interface IDateTimeProvider
{
    DateTimeOffset GetUtcNow();
}