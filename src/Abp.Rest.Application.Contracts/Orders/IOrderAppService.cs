using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Rest.Orders
{
    public interface IOrderAppService :
        IReadOnlyAppService<OrderDto, Guid, PagedAndSortedResultRequestDto>
    {
        Task<IEnumerable<OrderItemDto>> GetItems(Guid id);
    }
}