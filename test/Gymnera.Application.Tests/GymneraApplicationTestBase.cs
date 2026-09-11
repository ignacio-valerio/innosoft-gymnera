using Volo.Abp.Modularity;

namespace Gymnera;

public abstract class GymneraApplicationTestBase<TStartupModule> : GymneraTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
