using System;
using System.Collections.Generic;
using System.Text;
using ABPProject.Localization;
using Volo.Abp.Application.Services;

namespace ABPProject;

/* Inherit your application services from this class.
 */
public abstract class ABPProjectAppService : ApplicationService
{
    protected ABPProjectAppService()
    {
        LocalizationResource = typeof(ABPProjectResource);
    }
}
