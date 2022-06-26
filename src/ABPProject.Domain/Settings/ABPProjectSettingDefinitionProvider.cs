using Volo.Abp.Settings;

namespace ABPProject.Settings;

public class ABPProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPProjectSettings.MySetting1));
    }
}
