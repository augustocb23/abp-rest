using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.Rest
{
    [Dependency(ReplaceServices = true)]
    public class RestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Rest";
    }
}
