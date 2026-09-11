using Gymnera.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Gymnera.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GymneraController : AbpControllerBase
{
    protected GymneraController()
    {
        LocalizationResource = typeof(GymneraResource);
    }
}
