using ABPProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPProject.Permissions;

public class ABPProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABPProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABPProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPProjectResource>(name);
    }
}
