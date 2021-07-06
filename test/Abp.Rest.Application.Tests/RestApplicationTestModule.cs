using Volo.Abp.Modularity;

namespace Abp.Rest
{
    [DependsOn(
        typeof(RestApplicationModule),
        typeof(RestDomainTestModule)
        )]
    public class RestApplicationTestModule : AbpModule
    {

    }
}