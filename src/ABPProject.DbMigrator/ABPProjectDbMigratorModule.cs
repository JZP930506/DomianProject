using ABPProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABPProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPProjectEntityFrameworkCoreModule),
    typeof(ABPProjectApplicationContractsModule)
    )]
public class ABPProjectDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
