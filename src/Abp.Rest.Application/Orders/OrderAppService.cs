using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Rest.Permissions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Orders
{
    public sealed class OrderAppService :
        ReadOnlyAppService<Order, OrderDto, Guid, PagedAndSortedResultRequestDto>,
        IOrderAppService
    {
        public OrderAppService(IReadOnlyRepository<Order, Guid> repository) : base(repository)
        {
            GetPolicyName = OrdersPermissions.Orders;
            GetListPolicyName = OrdersPermissions.Orders;
        }

        public async Task<IEnumerable<OrderItemDto>> GetItems(Guid id)
        {
            var queryable = await Repository.GetQueryableAsync();
            var items = await queryable
                .Where(order => order.Id == id)
                .SelectMany(order => order.Items)
                .ToArrayAsync();

            return ObjectMapper.Map<IEnumerable<OrderItem>, IEnumerable<OrderItemDto>>(items);
        }
    }
}