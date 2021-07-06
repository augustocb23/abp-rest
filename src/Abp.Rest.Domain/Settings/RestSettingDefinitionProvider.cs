using Volo.Abp.Settings;

namespace Abp.Rest.Settings
{
    public class RestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(RestSettings.MySetting1));
        }
    }
}
