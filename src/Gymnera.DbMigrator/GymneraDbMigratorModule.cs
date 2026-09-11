using Gymnera.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Gymnera.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GymneraEntityFrameworkCoreModule),
    typeof(GymneraApplicationContractsModule)
)]
public class GymneraDbMigratorModule : AbpModule
{
}
