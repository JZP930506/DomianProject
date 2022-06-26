using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPProject.Data;

/* This is used if database provider does't define
 * IABPProjectDbSchemaMigrator implementation.
 */
public class NullABPProjectDbSchemaMigrator : IABPProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
