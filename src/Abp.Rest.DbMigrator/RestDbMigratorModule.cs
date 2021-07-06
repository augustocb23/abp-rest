using Abp.Rest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.Rest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(RestEntityFrameworkCoreDbMigrationsModule),
        typeof(RestApplicationContractsModule)
        )]
    public class RestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
