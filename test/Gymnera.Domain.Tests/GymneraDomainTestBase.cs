using Volo.Abp.Modularity;

namespace Gymnera;

/* Inherit from this class for your domain layer tests. */
public abstract class GymneraDomainTestBase<TStartupModule> : GymneraTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
