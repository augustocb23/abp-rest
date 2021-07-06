using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Rest.Data
{
    /* This is used if database provider does't define
     * IRestDbSchemaMigrator implementation.
     */
    public class NullRestDbSchemaMigrator : IRestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}