using System;
using System.Threading.Tasks;
using Abp.Rest.Orders;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Seeders
{
    public class ClientsSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Client, Guid> _repository;

        public ClientsSeeder(IRepository<Client, Guid> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() == 0)
            {
                await _repository.InsertManyAsync(ClientsData.GetData(), true);
            }
        }
    }
}