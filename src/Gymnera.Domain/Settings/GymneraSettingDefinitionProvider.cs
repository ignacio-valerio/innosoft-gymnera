using Volo.Abp.Settings;

namespace Gymnera.Settings;

public class GymneraSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GymneraSettings.MySetting1));
    }
}
