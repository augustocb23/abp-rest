using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Rest.Orders
{
    public class OrderDto : AuditedEntityDto<Guid>
    {
        public Guid ClientId { get; set; }
    }
}