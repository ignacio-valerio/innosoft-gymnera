using Volo.Abp.Modularity;

namespace Gymnera;

[DependsOn(
    typeof(GymneraApplicationModule),
    typeof(GymneraDomainTestModule)
)]
public class GymneraApplicationTestModule : AbpModule
{

}
