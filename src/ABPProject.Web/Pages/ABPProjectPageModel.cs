using ABPProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABPProject.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ABPProjectPageModel : AbpPageModel
{
    protected ABPProjectPageModel()
    {
        LocalizationResourceType = typeof(ABPProjectResource);
    }
}
