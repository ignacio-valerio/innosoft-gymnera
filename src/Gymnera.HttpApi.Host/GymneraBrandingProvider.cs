using Microsoft.Extensions.Localization;
using Gymnera.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Gymnera;

[Dependency(ReplaceServices = true)]
public class GymneraBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<GymneraResource> _localizer;

    public GymneraBrandingProvider(IStringLocalizer<GymneraResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
