using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abp.Rest.EntityFrameworkCore
{
    [DependsOn(
        typeof(RestEntityFrameworkCoreModule)
        )]
    public class RestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<RestMigrationsDbContext>();
        }
    }
}
