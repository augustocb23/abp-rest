using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Abp.Rest.Orders
{
    public class OrderDto : AuditedEntityDto<Guid>
    {
        public ClientDto Client { get; set; }
        public IEnumerable<OrderItemDto> Items { get; set; }
    }
}