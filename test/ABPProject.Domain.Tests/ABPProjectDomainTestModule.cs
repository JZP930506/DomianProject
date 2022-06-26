using ABPProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPProject;

[DependsOn(
    typeof(ABPProjectEntityFrameworkCoreTestModule)
    )]
public class ABPProjectDomainTestModule : AbpModule
{

}
