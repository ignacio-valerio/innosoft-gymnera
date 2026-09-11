using Gymnera.Localization;
using Volo.Abp.Application.Services;

namespace Gymnera;

/* Inherit your application services from this class.
 */
public abstract class GymneraAppService : ApplicationService
{
    protected GymneraAppService()
    {
        LocalizationResource = typeof(GymneraResource);
    }
}
