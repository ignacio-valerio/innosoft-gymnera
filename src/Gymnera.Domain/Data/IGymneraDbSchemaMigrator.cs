using System.Threading.Tasks;

namespace Gymnera.Data;

public interface IGymneraDbSchemaMigrator
{
    Task MigrateAsync();
}
