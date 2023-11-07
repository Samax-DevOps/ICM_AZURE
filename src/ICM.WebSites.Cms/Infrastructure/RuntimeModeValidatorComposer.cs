using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Infrastructure.Runtime.RuntimeModeValidators;

namespace ICM.WebSites.Cms.Infrastructure;

public class RuntimeModeValidatorComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
        => builder.RuntimeModeValidators().Remove<UseHttpsValidator>();
}