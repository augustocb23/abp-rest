using System;
using Abp.Rest.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Orders
{
    public sealed class ProductAppService :
        CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, ProductEditDto>,
        IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
            GetPolicyName = OrdersPermissions.Products;
            GetListPolicyName = OrdersPermissions.Products;
            CreatePolicyName = OrdersPermissions.Products;
            UpdatePolicyName = OrdersPermissions.Products;
            DeletePolicyName = OrdersPermissions.Products;
        }
    }
}