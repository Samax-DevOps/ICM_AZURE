using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;

namespace ICM.WebSites.Extensions;

public static class PublishedContentExtensions
{
    public static IPublishedContent? GetByKey(this IPublishedCache? content, string guid)
    {
        return content?.GetById(new Guid(guid));
    }
}