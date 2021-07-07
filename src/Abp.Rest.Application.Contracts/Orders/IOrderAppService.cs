using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Rest.Orders
{
    public interface IOrderAppService :
        IReadOnlyAppService<OrderDto, Guid, PagedAndSortedResultRequestDto>
    {
    }
}