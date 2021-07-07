using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Orders
{
    public class OrderAppService:
        ReadOnlyAppService<Order, OrderDto, Guid, PagedAndSortedResultRequestDto>,
        IOrderAppService
    {
        public OrderAppService(IReadOnlyRepository<Order, Guid> repository) : base(repository)
        {
        }
    }
}