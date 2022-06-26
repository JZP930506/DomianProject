using Volo.Abp.Modularity;

namespace ABPProject;

[DependsOn(
    typeof(ABPProjectApplicationModule),
    typeof(ABPProjectDomainTestModule)
    )]
public class ABPProjectApplicationTestModule : AbpModule
{

}
