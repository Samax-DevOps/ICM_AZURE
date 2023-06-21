using Umbraco.Cms.Web.Common;

namespace ICM.WebSites.Umbraco.Extensions;

public static class UmbracoHelperExtensions
{
    public static string FromDictionary(this UmbracoHelper helper, string key)
    {
        var value = helper.GetDictionaryValue(key);
        return !string.IsNullOrWhiteSpace(value) ? value : key;
    }
}