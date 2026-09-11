using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Gymnera.Data;

/* This is used if database provider does't define
 * IGymneraDbSchemaMigrator implementation.
 */
public class NullGymneraDbSchemaMigrator : IGymneraDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
