using ABPProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPProjectController : AbpControllerBase
{
    protected ABPProjectController()
    {
        LocalizationResource = typeof(ABPProjectResource);
    }
}
