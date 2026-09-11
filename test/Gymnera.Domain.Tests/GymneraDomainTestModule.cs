using Volo.Abp.Modularity;

namespace Gymnera;

[DependsOn(
    typeof(GymneraDomainModule),
    typeof(GymneraTestBaseModule)
)]
public class GymneraDomainTestModule : AbpModule
{

}
