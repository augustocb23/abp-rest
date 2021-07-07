using System;
using System.Threading.Tasks;
using Abp.Rest.Orders;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Seeders
{
    public class OrdersSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Order, Guid> _repository;

        public OrdersSeeder(IRepository<Order, Guid> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.CountAsync() == 0)
            {
                await _repository.InsertManyAsync(OrdersData.GetData(), true);
            }
        }
    }
}