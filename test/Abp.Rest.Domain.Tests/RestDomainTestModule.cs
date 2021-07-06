using Abp.Rest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Rest
{
    [DependsOn(
        typeof(RestEntityFrameworkCoreTestModule)
        )]
    public class RestDomainTestModule : AbpModule
    {

    }
}