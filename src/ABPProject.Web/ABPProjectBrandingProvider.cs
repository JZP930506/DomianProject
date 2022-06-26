using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABPProject.Web;

[Dependency(ReplaceServices = true)]
public class ABPProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABPProject";
}
