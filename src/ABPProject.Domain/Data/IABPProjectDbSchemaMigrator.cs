using System.Threading.Tasks;

namespace ABPProject.Data;

public interface IABPProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
