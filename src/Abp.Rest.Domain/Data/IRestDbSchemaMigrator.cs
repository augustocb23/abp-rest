using System.Threading.Tasks;

namespace Abp.Rest.Data
{
    public interface IRestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
