using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Orders
{
    public class ProductAppService:  CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, ProductEditDto>,
        IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
        }
    }
}