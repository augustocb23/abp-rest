using System;
using System.Threading.Tasks;
using Abp.Rest.Orders;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Seeders
{
    public class ProductsSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, Guid> _repository;

        public ProductsSeeder(IRepository<Product, Guid> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() == 0)
            {
                await _repository.InsertManyAsync(ProductsData.GetData(), true);
            }
        }
    }
}